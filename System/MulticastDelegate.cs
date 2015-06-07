// Copyright (C) 2014 dot42
//
// Original filename: MulticastDelegate.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Reflection;
using Dot42;
using Java.Util.Concurrent.Atomic;

namespace System
{
    abstract partial class MulticastDelegate : Delegate
    {
        // http://csharpindepth.com/Articles/Chapter2/Events.aspx
        //                                        in particular the table on removal 
        //                                        and addition of delegates.

        // MulticastDelegate is immutable per specification.
        //
        // In our implementation, we always have a head (this), and possibly
        // a tail, stored in 'invocationList', its length defined by 
        // 'invocationListLength'.
        // The invocation list will only contain delegates that 
        // do not have an invocation list on their own, i.e. we always have
        // a flat invocation list.
        // We try to minimize the number of new allocations by sharing the 
        // invocation list between instances, if possible. Also, we only 
        // create an invocation list when required. 

        [Include]
        protected int InvocationListLength;

        [Include]
	    protected AtomicReferenceArray<MulticastDelegate> InvocationList;

        protected abstract bool EqualsWithoutInvocationList(object other);
        [DexName("CloneWithNewInvocationList")]
        protected abstract MulticastDelegate CloneWithNewInvocationList(AtomicReferenceArray<MulticastDelegate> invocationList, int invocationListLength);

        protected override sealed Delegate CombineImpl(Delegate other)
        {
            if (other == null)
                return this;

            MulticastDelegate o = (MulticastDelegate) other;

            var oInvList = o.InvocationList;
            var oInvLen = o.InvocationListLength;

            o = o.StripInvocationList(); // we flatten the list. 

            var newInvList = InvocationList;
            int newInvLen = InvocationListLength + 1 + oInvLen;

            bool needNewList = newInvList == null || newInvList.Length() < newInvLen;

            // try appending to the current list.
            if (!needNewList)
            {
                if (!newInvList.CompareAndSet(InvocationListLength, null, o))
                    needNewList = true;
                else
                {
                    for (int i = 0; i < oInvLen; ++i)
                    {
                        if (!newInvList.CompareAndSet(InvocationListLength + i + 1, null, oInvList.Get(i)))
                        {
                            // can this even happen when the first set succeeded?
                            needNewList = true;
                            break;
                        }
                    }
                }
            }

            if (needNewList)
            {
                // start by 4, duplicate size.
                int len = newInvList == null ? 4 : newInvList.Length();
                while (len < newInvLen)
                    len *= 2;

                MulticastDelegate[] list = new MulticastDelegate[len];

                for(int i = 0; i < InvocationListLength; ++i)
                    list[i] = InvocationList.Get(i);
                
                list[InvocationListLength] = o;
                
                for (int i = 0; i < oInvLen; ++i)
                    list[InvocationListLength + 1 + i] = oInvList.Get(i);

                newInvList = new AtomicReferenceArray<MulticastDelegate>(list);
            }

            return CloneWithNewInvocationList(newInvList, newInvLen);
        }

        protected override sealed Delegate RemoveImpl(Delegate other)
        {
            if (ReferenceEquals(other, this))
                return null;

            MulticastDelegate o = (MulticastDelegate)other;

            int idx = LastIndexOf(o);

            if (idx == -1)
                return this;

            var newNumDelegates = InvocationListLength - o.InvocationListLength;

            if (newNumDelegates == 0)
                return null;

            if (newNumDelegates == 1)
            {
                if (idx == 0)
                    return StripInvocationList();
                return InvocationList.Get(idx - 1);
            }

            int newInvListLen = newNumDelegates - 1;
            AtomicReferenceArray<MulticastDelegate> newInvList;
            MulticastDelegate head;

            if (idx == 0)
            {
                head = InvocationList.Get(o.InvocationListLength);
                newInvList = RemoveSliceFromInvocationList(0, o.InvocationListLength + 1);
            }
            else
            {
                head = this;
                newInvList = RemoveSliceFromInvocationList(idx - 1, o.InvocationListLength + 1);    
            }

            return head.CloneWithNewInvocationList(newInvList, newInvListLen);
        }

        public override Delegate[] GetInvocationList()
        {
            Delegate[] ret = new Delegate[1 + InvocationListLength];
            ret[0] = this.StripInvocationList();
            for (int i = 1; i <= InvocationListLength; ++i)
                ret[i] = InvocationList.Get(i - 1);
            return ret;
        }

        private MulticastDelegate StripInvocationList()
        {
            if (InvocationListLength == 0)
                return this;
            return CloneWithNewInvocationList(null, 0);
        }

        /// <summary>
	    /// return the class instance or null, if this is a static delegate.
	    /// </summary>
	    public override object Target 
	    {
	        get
	        {
	            FieldInfo field;
                // we need to return the last Target from our invocation list.
                if (InvocationListLength > 0)
	            {
                    var del = InvocationList.Get(InvocationListLength - 1);
	                field = del.GetInstanceField();
	                return field == null ? null : field.GetValue(del);
	            }

                field = this.GetInstanceField();
                return field == null ? null : field.GetValue(this);
            }
	    }

        internal override MethodInfo Method
        {
            get
            {
                // we need to return the last Method from our invocation list.
                if(InvocationListLength > 0)
                    return InvocationList.Get(InvocationListLength-1).GetMethodInfo();
                return GetMethodInfo();
            }
        }

        public override bool Equals(object other)
        {
            // we have to check for same type and same invocation list.
            var o = other as MulticastDelegate;

            if (o == null)
                return false;

            if (!EqualsWithoutInvocationList(o))
                return false;

            if (InvocationListLength != o.InvocationListLength)
                return false;

            var oInvList = o.InvocationList;
            for(int i = 0; i < InvocationListLength; ++i)
            {
                if (!InvocationList.Get(i).EqualsWithoutInvocationList(oInvList.Get(i)))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            // GetType() maps to the called method.
            return GetType().GetHashCode() * 33 + InvocationListLength;
        }

        private AtomicReferenceArray<MulticastDelegate> RemoveSliceFromInvocationList(int idx, int length)
        {
            var invList = InvocationList;
            int invListLen = InvocationListLength;

            int newInvLen = invListLen - length;
            int trueInvListLen = invList.Length();

            bool canKeepList = newInvLen == idx && (trueInvListLen <= 4 || trueInvListLen/2 <= newInvLen);

            if(canKeepList)
                return invList;

            trueInvListLen = 4;
            while (trueInvListLen < newInvLen)
                trueInvListLen *= 2;

            MulticastDelegate[] newList = new MulticastDelegate[trueInvListLen];

            for (int i = 0; i < idx; ++i)
                newList[i] = invList.Get(i);
            for (int i = idx + length, j = idx; j < newInvLen; ++i, ++j)
                newList[j] = invList.Get(i);

            return new AtomicReferenceArray<MulticastDelegate>(newList);
        }

        /// <summary>
        /// Will return an index into [head] + tail, or -1 if not found 
        /// </summary>
        private int LastIndexOf(MulticastDelegate o)
        {
            int oInvLen = o.InvocationListLength;
            var oInvList = o.InvocationList;

            // We need to start comparing from the end.

            // Mono's implementation uses the KMP algorithm, but at a first
            // glance this seems to be overkill for an invocation list...
            // We stick to the naive implementation for now.
            for (int i = InvocationListLength - oInvLen - 1; i >= -1; --i) // -1 = this.
            {
                // compare o itself
                if (i == -1)
                {
                    if (!this.EqualsWithoutInvocationList(o))
                        return -1;
                }
                else
                {
                    if (!InvocationList.Get(i).EqualsWithoutInvocationList(o))
                        continue;
                }

                for (int j = 0; j < oInvLen; ++j)
                {
                    if (!InvocationList.Get(i + 1 + j).EqualsWithoutInvocationList(oInvList.Get(j)))
                        goto next_iteration;
                }

                // found it!
                return i + 1;

            next_iteration: ;
            }

            return -1;
        }
    }
}
