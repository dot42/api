// Copyright (C) 2014 dot42
//
// Original filename: Delegate.cs
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
using Dot42.Collections.Specialized;
using Dot42.Internal;
using Java.Util.Concurrent;

namespace System
{
	public abstract partial class Delegate
	{
        private static readonly ConcurrentTypeHashMap<FieldInfo> InstanceFieldCache = new ConcurrentTypeHashMap<FieldInfo>();
        private static readonly ConcurrentTypeHashMap<MethodInfo> TargetMethodCache = new ConcurrentTypeHashMap<MethodInfo>();
        //private static readonly ConcurrentHashMap<Type, FieldInfo> InstanceFieldCache = new ConcurrentHashMap<Type, FieldInfo>();
        //private static readonly ConcurrentHashMap<Type, MethodInfo> TargetMethodCache = new ConcurrentHashMap<Type, MethodInfo>();

	    static Delegate()
	    {
	        Application.ReleaseCaches += (s, e) =>
	        {
	            InstanceFieldCache.Clear();
	            TargetMethodCache.Clear();
	        };
	    }
        /// <summary>
        /// Concatenates an invocation list of 2 delegates.
        /// </summary>
        public static Delegate Combine(Delegate a, Delegate b)
        {
            if (a == null) return b;
            if (b == null) return a;
            return a.CombineImpl(b);
        }

        /// <summary>
        /// Remove the value delegate from the source delegate.
        /// </summary>
        public static Delegate Remove(Delegate source, Delegate value)
        {
            if (value == null) return source;
            if (source == null) return null;
            return source.RemoveImpl(value);
        }

        /// <summary>
        /// Add the given delegate to the end of my invocation list.
        /// </summary>
	    protected abstract Delegate CombineImpl(Delegate other);

        /// <summary>
        /// Remove the given delegate from my invocation list.
        /// </summary>
        protected abstract Delegate RemoveImpl(Delegate other);

	    /// <summary>
	    /// return the class instance or null, if this is a static delegate.
	    /// </summary>
	    public abstract object Target { get; }

	    internal abstract MethodInfo Method { get; }

        /// <summary>
        /// returns the invocation list
        /// </summary>
	    public virtual Delegate[] GetInvocationList()
	    {
	        return new [] { this };
	    }

	    public static bool operator == (Delegate d1, Delegate d2)
	    {
	        if (ReferenceEquals(d1, null))
	            return ReferenceEquals(d2, null);
	        return d1.Equals(d2);
	    }

	    public static bool operator !=(Delegate d1, Delegate d2)
	    {
	        return !(d1 == d2);
	    }

        protected FieldInfo GetInstanceField()
        {
            var ret = InstanceFieldCache.Get(this.GetType());
            
            if (ReferenceEquals(ret, FieldInfo.None))
                return null;
            if (ret != null)
                return ret;

            ret = GetType().GetField("instance", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            ret = ret ?? FieldInfo.None;
            ret = InstanceFieldCache.PutIfAbsent(this.GetType(), ret) ?? ret;

            if (ReferenceEquals(ret, FieldInfo.None))
                return null;
            return ret;
        }

        protected MethodInfo GetMethodInfo()
        {
            var ret = TargetMethodCache.Get(this.GetType());
            if (ret != null)
                return ret;

            var annotation = GetType().GetAnnotation<IDelegateMethod>(typeof(IDelegateMethod));
            if (annotation == null)
                throw new NotImplementedException("delegate annotation missing.");
         
            ret = new MethodInfo(annotation.Method(), this.GetType());

            return TargetMethodCache.PutIfAbsent(this.GetType(), ret) ?? ret;
        }
	}
}

