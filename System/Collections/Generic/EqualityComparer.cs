//
// Comparer
//
// Authors:
//	Ben Maurer (bmaurer@ximian.com)
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System.Diagnostics.CodeAnalysis;
using Android.Widget;
using Dot42.Collections.Specialized;
using Java.Lang.Ref;

namespace System.Collections.Generic {
	[Serializable]
	public abstract class EqualityComparer <T> : IEqualityComparer, IEqualityComparer <T> 
    {
        [SuppressMessage("dot42", "StaticFieldInGenericType")]
        //private static readonly FastImmutableHashMap<Type, Reference<object>> Comparers = new FastImmutableHashMap<Type, Reference<object>>(new FastWeakReferenceHashMap<Type, Reference<object>>(16));
        private static readonly ConcurrentTypeHashMap<object> Comparers = new ConcurrentTypeHashMap<object>();
		
	    public abstract int GetHashCode (T obj);
		public abstract bool Equals (T x, T y);
	
        // Works with dot42's generics implementation.
        // We try to return the very same instance for the same class.
	    public static EqualityComparer<T> Default
	    {
	        get
	        {
                object previous = null;
	            var type = typeof (T);
                
	            var comparer = Comparers.Get(type);
                if(comparer == null)
	                previous = Comparers.PutIfAbsent(type, comparer = CreateComparer(type));

	            return (EqualityComparer<T>) (previous ?? comparer);
	        }
	    }

        // The goal is to hold weak-/softreferences to both type and comparer,
        // to allow the garbage collector to reclaim unused types and classloaders.
        // If java would support Ephemerons, we would use them to attach our comparer
        // to the type.
	    //public static EqualityComparer<T> Default 
        //{
        //    get
        //    {
        //        object previous = null;
        //        Reference<object> comparerRef = Comparers.Get(typeof (T));
        //        object comparer = comparerRef == null ? null : comparerRef.Get();
        //        object newComparer = null;
        //        SoftReference<object> newReference = null;

        //        while (comparer == null)
        //        {
        //            comparer = newComparer = newComparer ?? CreateComparer(typeof (T));
        //            newReference = newReference ?? new SoftReference<object>(comparer);

        //            if (previous == null)
        //            {
        //                // detect race conditions.
        //                previous = Comparers.PutIfAbsent(typeof (T), newReference);
        //                if (previous != null)
        //                    comparer = ((Reference<object>) previous).Get();
        //            }
        //            else
        //            {
        //                // Without ephemerons, we seem to have no chance to force returning
        //                // the very same instance. A third thread could just grab our just
        //                // set instance, if we would try to revert a wrong setting.
        //                // This means that two concurrent calls to EqualityComparer<T>.Default 
        //                // possibly lead to two different instances. Probably not a big
        //                // thing.
        //                previous = Comparers.Put(typeof(T), newReference);
        //                comparer = newComparer;
        //            }
        //        }
        //        return (EqualityComparer<T>)comparer;
        //    }
        //}

		int IEqualityComparer.GetHashCode (object obj)
		{
			if (obj == null)
				return 0;

			if (!(obj is T))
				throw new ArgumentException ("Argument is not compatible", "obj");

			return GetHashCode ((T)obj);
		}

		bool IEqualityComparer.Equals (object x, object y)
		{
			if (x == y)
				return true;

			if (x == null || y == null)
				return false;

			if (!(x is T))
				throw new ArgumentException ("Argument is not compatible", "x");
			if (!(y is T))
				throw new ArgumentException ("Argument is not compatible", "y");
			return Equals ((T)x, (T)y);
		}

        private static EqualityComparer<T> CreateComparer(Type type)
        {
            if (type == typeof(string))
            {
                return (EqualityComparer<T>)(object)new InternalStringComparer();
            }
            if (typeof(IEquatable<T>).IsAssignableFrom(type))
                return (EqualityComparer<T>)
                        Activator.CreateInstance(typeof(GenericEqualityComparer<>).MakeGenericType(typeof(T)));
            else
                return new DefaultComparer();
        }

		[Serializable]
		internal sealed class DefaultComparer : EqualityComparer<T> 
        {
	
			public override int GetHashCode (T obj)
			{
				if (obj == null)
					return 0;
				return obj.GetHashCode ();
			}
	
			public override bool Equals (T x, T y)
			{
				if (x == null)
					return y == null;

				return x.Equals (y);
			}
		}
	}
	
	[Serializable]
	sealed class InternalStringComparer : EqualityComparer<string> {
	
		public override int GetHashCode (string obj)
		{
			if (obj == null)
				return 0;
			return obj.GetHashCode ();
		}
	
		public override bool Equals (string x, string y)
		{
			if (x == null)
				return y == null;

			if ((object) x == (object) y)
				return true;
				
			return x.Equals (y);
		}
	}

	[Serializable]
	sealed class GenericEqualityComparer <T> : EqualityComparer <T> where T : IEquatable <T> 
    {

		public override int GetHashCode (T obj)
		{
			if (obj == null)
				return 0;
			return obj.GetHashCode ();
		}

		public override bool Equals (T x, T y)
		{
			if (x == null)
				return y == null;
			
			return x.Equals (y);
		}
	}
}

