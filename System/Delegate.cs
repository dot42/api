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
using Dot42.Internal;

namespace System
{
	public abstract partial class Delegate
	{
        /// <summary>
        /// Concatenates an invocation list of 2 delegates.
        /// </summary>
        public static Delegate Combine(Delegate a, Delegate b)
        {
            if (a == null) return b;
            if (b == null) return a;
            a.Add(b);
            return a;
        }

        /// <summary>
        /// Remove the value delegate from the source delegate.
        /// </summary>
        public static Delegate Remove(Delegate source, Delegate value)
        {
            if (value == null) return source;
            return source.Remove(value);
        }

        /// <summary>
        /// Add the given delegate to the end of my invocation list.
        /// </summary>
	    protected abstract void Add(Delegate other);

        /// <summary>
        /// Remove the given delegate from my invocation list.
        /// </summary>
        protected abstract Delegate Remove(Delegate other);

	    /// <summary>
	    /// return the class instance or null, if this is a static delegate.
	    /// </summary>
	    public object Target
	    {
	        get
	        {
                // don't care about performance 
	            var field = GetType().GetField("instance");
	            if (field == null) return null;
	            return field.GetValue(this);
	        }
	    }

	    internal MethodInfo Method
	    {
	        get
	        {
	            var annotation = GetType().GetAnnotation<IDelegateMethod>(typeof (IDelegateMethod));
                if(annotation == null)
                    throw new NotImplementedException("delegate annotation missing.");

	            return annotation.Method();
	        }
	    }

        /// <summary>
        /// returns the invocation list
        /// </summary>
	    public virtual Delegate[] GetInvocationList()
	    {
	        return new [] { this };
	    }

	    public static bool operator ==(Delegate d1, Delegate d2)
	    {
	        if (ReferenceEquals(d1, null))
	            return ReferenceEquals(d2, null);
	        return d1.Equals(d2);
	    }

	    public static bool operator !=(Delegate d1, Delegate d2)
	    {
	        return !(d1 == d2);
	    }
	}
}

