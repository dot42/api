// Copyright (C) 2014 dot42
//
// Original filename: CompilerHelper.Array.cs
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dot42.Internal
{
	partial class CompilerHelper
	{
        /// <summary>
        /// Perform the is operator like "value is System.Array".
        /// </summary>
        [Include(TypeCondition = typeof(Array))]
        [Include(TypeCondition = typeof(IEnumerable))]
        [Include(TypeCondition = typeof(ICollection))]
        [Include(TypeCondition = typeof(IList))]
        public static bool IsArray(object value)
        {
            return ((value != null) && value.GetType().IsArray);
        }

        /// <summary>
        /// Perform the cast operator like "(System.Array)value".
        /// </summary>
        [Include(TypeCondition = typeof(Array))]
        public static object CastToArray(object value)
        {
            if ((value == null) || value.GetType().IsArray) return value;
            throw new InvalidCastException();
        }

        /// <summary>
        /// Perform the cast operator like "(System.Collections.IEnumerable)value".
        /// </summary>
        [Include(TypeCondition = typeof(IEnumerable))]
        public static IEnumerable CastToEnumerable(object value)
        {
            if (value == null) return null;
            var enumerable = AsEnumerable(value);
            if (enumerable == null) throw new InvalidCastException();
            return enumerable;
        }

        /// <summary>
        /// Perform the cast operator like "(System.Collections.ICollection)value".
        /// </summary>
        [Include(TypeCondition = typeof(ICollection))]
        public static ICollection CastToCollection(object value)
        {
            if (value == null) return null;
            var collection = AsCollection(value);
            if (collection == null) throw new InvalidCastException();
            return collection;
        }

        /// <summary>
        /// Perform the cast operator like "(System.Collections.IList)value".
        /// </summary>
        [Include(TypeCondition = typeof(IList))]
        public static IList CastToList(object value)
        {
            if (value == null) return null;
            var list = AsList(value);
            if (list == null) throw new InvalidCastException();
            return list;
        }

        /// <summary>
        /// Perform the is operator like "value as System.Array".
        /// </summary>
        [Include(TypeCondition = typeof(Array))]
        public static object AsArray(object value)
        {
            if (value == null) return null;
            return value.GetType().IsArray ? value : null;
        }

        /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
	    public static IEnumerable<byte> AsByteEnumerable(object value)
	    {
            return new ArrayIEnumerable<byte>((byte[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
	    public static IEnumerable<sbyte> AsSByteEnumerable(object value)
	    {
            return new ArrayIEnumerable<sbyte>((sbyte[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
	    public static IEnumerable<bool> AsBoolEnumerable(object value)
	    {
            return new ArrayIEnumerable<bool>((bool[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<char> AsCharEnumerable(object value)
	    {
            return new ArrayIEnumerable<char>((char[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<short> AsInt16Enumerable(object value)
	    {
            return new ArrayIEnumerable<short>((short[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<ushort> AsUInt16Enumerable(object value)
	    {
            return new ArrayIEnumerable<ushort>((ushort[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<int> AsInt32Enumerable(object value)
	    {
            return new ArrayIEnumerable<int>((int[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<uint> AsUInt32Enumerable(object value)
	    {
            return new ArrayIEnumerable<uint>((uint[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<long> AsInt64Enumerable(object value)
	    {
            return new ArrayIEnumerable<long>((long[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<float> AsFloatEnumerable(object value)
	    {
            return new ArrayIEnumerable<float>((float[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable<double> AsDoubleEnumerable(object value)
	    {
            return new ArrayIEnumerable<double>((double[])value);
	    }

	    /// <summary>
	    /// Convert an array to an IEnumerable instance.
	    /// </summary>
	    [Include(TypeCondition = typeof(IEnumerable))]
	    [Include(TypeCondition = typeof(IEnumerable<>))]
	    [EditorBrowsable(EditorBrowsableState.Advanced)]
	    public static IEnumerable<object> AsObjectEnumerable(object value)
	    {
            return new ArrayIEnumerable<object>((object[])value);
	    }


        /// <summary>
        /// Gets an enumerator to enumerate over all elements of this array.
        /// </summary>
        [Include(TypeCondition = typeof(IEnumerable))]
        [Include(TypeCondition = typeof(IEnumerable<>))]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IEnumerable AsEnumerable(object value)
        {
            if (value == null) return null;
            if (value is sbyte[]) return AsByteEnumerable(value);
            if (value is bool[]) return AsBoolEnumerable(value);
            if (value is char[]) return AsCharEnumerable(value);
            if (value is short[]) return AsInt16Enumerable(value);
            if (value is int[]) return AsInt32Enumerable(value);
            if (value is long[]) return AsInt64Enumerable(value);
            if (value is float[]) return AsFloatEnumerable(value);
            if (value is double[]) return AsDoubleEnumerable(value);
            if (value is object[]) return AsObjectEnumerable(value);
            return null;
        }

        /// <summary>
        /// Convert an array to an ICollection instance.
        /// </summary>
        [Include(TypeCondition = typeof(ICollection))]
        [Include(TypeCondition = typeof(System.Collections.Generic.ICollection<>))]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ICollection AsCollection(object value)
        {
            var array = value as Array;
            return (array != null) ? new ArrayCollectionWrapper(array) : null;
        }

        /// <summary>
        /// Convert an array to an IList instance.
        /// </summary>
        [Include(TypeCondition = typeof(IList))]
        [Include(TypeCondition = typeof(IList<>))]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static IList AsList(object value)
        {
            var array = value as Array;
            return (array != null) ? new ArrayListWrapper(array) : null;
        }

        /// <summary>
        /// ICollection wrapper for array's
        /// </summary>
        [Include(TypeCondition = typeof(ICollection))]
        [Include(TypeCondition = typeof(System.Collections.Generic.ICollection<>))]
        private class ArrayCollectionWrapper : ICollection, ICollection<object>
        {
            protected readonly Array array;

            /// <summary>
            /// Default ctor
            /// </summary>
            public ArrayCollectionWrapper(Array array)
            {
                this.array = array;
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                return (IEnumerator<object>) GetEnumerator();
            }

            /// <summary>
            /// Gets an enumerator over all elements of the array
            /// </summary>
            public IEnumerator GetEnumerator()
            {
                return AsEnumerable(array).GetEnumerator();
            }

            /// <summary>
            /// Gets the array length
            /// </summary>
            public int Count
            {
                get { return Java.Lang.Reflect.Array.GetLength(array); }
            }

            public bool IsReadOnly { get; private set; }
            public void Add(object item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                Array.Clear(array, 0, Java.Lang.Reflect.Array.GetLength(array));
            }

            public bool Contains(object element)
            {
                return (Array.IndexOf(array, element) >= 0);
            }

            public bool Remove(object item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(object[] destination, int index)
            {
                Java.Lang.System.Arraycopy(array, 0, destination, index, Java.Lang.Reflect.Array.GetLength(array));
            }

            /// <summary>
            /// Is this collection thread safe.
            /// </summary>
            public bool IsSynchronized { get { return false; } }

            /// <summary>
            /// Gets the object used to synchronize access to this collection.
            /// </summary>
            public object SyncRoot { get { return array; } }

            /// <summary>
            /// Copy all my elements to the given array starting at the given index.
            /// </summary>
            /// <param name="array">Array to copy my elements into.</param>
            /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
            public void CopyTo(Array destination, int index)
            {
                Java.Lang.System.Arraycopy(array, 0, destination, index, Java.Lang.Reflect.Array.GetLength(array));
            }
        }

        /// <summary>
        /// IList wrapper for array's
        /// </summary>
        [Include(TypeCondition = typeof(IList))]
        [Include(TypeCondition = typeof(IList<>))]
        private class ArrayListWrapper : ArrayCollectionWrapper, IList, IList<object>
        {
            public ArrayListWrapper(Array array) : base(array)
            {
            }

            public bool IsFixedSize { get { return true; } }
            public bool IsReadOnly { get { return false; } }

            public object this[int index]
            {
                get { return Java.Lang.Reflect.Array.Get(array, index); }
                set { Java.Lang.Reflect.Array.Set(array, index, value); }
            }

            public int Add(object element)
            {
                throw new NotSupportedException();
            }

            public int IndexOf(object element)
            {
                return Array.IndexOf(array, element);
            }

            public void Insert(int index, object element)
            {
                throw new NotSupportedException();
            }

            public void Remove(object element)
            {
                throw new NotSupportedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotSupportedException();
            }
        }
    }
}

