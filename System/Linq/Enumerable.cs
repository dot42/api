//
// Enumerable.cs
//
// Modified by TallApplications for improved Android support.
//
//
// Authors:
//  Marek Safar (marek.safar@gmail.com)
//  Antonello Provenzano  <antonello@deveel.com>
//  Alejandro Serrano "Serras" (trupill@yahoo.es)
//  Jb Evain (jbevain@novell.com)
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
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

// precious: http://www.hookedonlinq.com

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using Dot42;
using Java.Lang;
using Java.Util;

namespace System.Linq
{
	public static class Enumerable
	{
		enum Fallback {
			Default,
			Throw
		}

        [SuppressMessage("dot42", "StaticFieldInGenericType")]
        [SuppressMessage("dot42", "StaticConstructorUsesGenericParameter")]
		static class PredicateOf<T> {
			public static readonly Func<T, bool> Always = (t) => true;
		}

        [SuppressMessage("dot42", "StaticFieldInGenericType")]
		static class Function<T> {
			public static readonly Func<T, T> Identity = (t) => t;
		}

	    private static class EmptyOf<T>
	    {
	        public static T[] Instance()
	        {
	            return new T[0];
	        }
	    }

	    static class ReadOnlyCollectionOf<T> {
	        public static ReadOnlyCollection<T> Empty()
	        {
	            return new ReadOnlyCollection<T>(EmptyOf<T>.Instance());
	        }
	    }

		#region Aggregate

		public static TSource Aggregate<TSource> (this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			Check.SourceAndFunc (source, func);

			// custom foreach so that we can efficiently throw an exception
			// if zero elements and treat the first element differently
			using (var enumerator = source.GetEnumerator ()) {
				if (!enumerator.MoveNext ())
					throw new InvalidOperationException ("No elements in source list");

				TSource folded = enumerator.Current;
				while (enumerator.MoveNext ())
					folded = func (folded, enumerator.Current);
				return folded;
			}
		}

        public static TSource Aggregate<TSource>(this IIterable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            Check.SourceAndFunc(source, func);
            return source.AsEnumerable().Aggregate(func);
        }

        public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source,
			TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			Check.SourceAndFunc (source, func);

			TAccumulate folded = seed;
			foreach (TSource element in source)
				folded = func (folded, element);

			return folded;
		}

        public static TAccumulate Aggregate<TSource, TAccumulate>(this IIterable<TSource> source,
            TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            Check.SourceAndFunc(source, func);
            return source.AsEnumerable().Aggregate(seed, func);
        }

        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
		{
			Check.SourceAndFunc (source, func);
			if (resultSelector == null)
				throw new ArgumentNullException ("resultSelector");

			var result = seed;
			foreach (var e in source)
				result = func (result, e);

			return resultSelector (result);
		}

        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IIterable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            Check.SourceAndFunc(source, func);
            return source.AsEnumerable().Aggregate(seed, func, resultSelector);
        }

        #endregion

		#region All

		public static bool All<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			foreach (var element in source)
				if (!predicate (element))
					return false;

			return true;
		}

        public static bool All<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);
            return source.AsEnumerable().All(predicate);
        }

        #endregion

		#region Any

		public static bool Any<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var collection = source as Collections.Generic.ICollection<TSource>;
			if (collection != null)
				return collection.Count > 0;

			using (var enumerator = source.GetEnumerator ())
				return enumerator.MoveNext ();
		}

        public static bool Any<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            var collection = source as Java.Util.ICollection<TSource>;
            if (collection != null)
                return collection.Size() > 0;

            return source.AsEnumerable().Any();
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			foreach (TSource element in source)
				if (predicate (element))
					return true;

			return false;
		}

        public static bool Any<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);
            return source.AsEnumerable().Any(predicate);
        }

        #endregion

		#region AsEnumerable

		public static IEnumerable<TSource> AsEnumerable<TSource> (this IEnumerable<TSource> source)
		{
			return source;
		}

		#endregion

		#region Average

		public static double Average (this IEnumerable<int> source)
		{
			Check.Source (source);

			long total = 0;
			int count = 0;
			foreach (var element in source){
				total = checked (total + element);
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / (double) count;
		}

        public static double Average(this IIterable<int> source)
        {
            Check.Source(source);
            return Average(source.AsEnumerable());
        }

        public static double Average(this IEnumerable<long> source)
		{
			Check.Source (source);

			long total = 0;
			long count = 0;
			foreach (var element in source){
				total += element;
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / (double) count;
		}

        public static double Average(this IIterable<long> source)
        {
            Check.Source(source);
            return Average(source.AsEnumerable());
        }

        public static double Average(this IEnumerable<double> source)
		{
			Check.Source (source);

			double total = 0;
			long count = 0;
			foreach (var element in source){
				total += element;
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;
		}

        public static double Average(this IIterable<float> source)
        {
            Check.Source(source);
            return Average(source.AsEnumerable());
        }

        public static float Average(this IEnumerable<float> source)
		{
			Check.Source (source);

			float total = 0;
			long count = 0;
			foreach (var element in source){
				total += element;
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;
		}

		public static decimal Average (this IEnumerable<decimal> source)
		{
			Check.Source (source);

			decimal total = 0;
			long count = 0;
			foreach (var element in source){
				total += element;
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;
		}

		static TResult? AverageNullable<TElement, TAggregate, TResult> (this IEnumerable<TElement?> source,
			Func<TAggregate, TElement, TAggregate> func, Func<TAggregate, long, TResult> result)
			where TElement : struct
			where TAggregate : struct
			where TResult : struct
		{
			Check.Source (source);

			var total = default (TAggregate);
			long counter = 0;
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = func (total, element.Value);
				counter++;
			}

			if (counter == 0)
				return null;

			return new TResult? (result (total, counter));
		}

		public static double? Average (this IEnumerable<int?> source)
		{
			Check.Source (source);

			long total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = total + element.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / (double) counter);
		}

		public static double? Average (this IEnumerable<long?> source)
		{
			Check.Source (source);

			long total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = checked (total + element.Value);
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / (double) counter);

		}

		public static double? Average (this IEnumerable<double?> source)
		{
			Check.Source (source);

			double total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = total + element.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / counter);

		}

		public static decimal? Average (this IEnumerable<decimal?> source)
		{
			Check.Source (source);

			decimal total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = total + element.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new decimal? (total / counter);

		}

		public static float? Average (this IEnumerable<float?> source)
		{
			Check.Source (source);

			float total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				total = total + element.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new float? (total / counter);

		}

		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			long count = 0;
			foreach (var element in source){
				total += selector (element);
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / (double) count;
		}

        public static double Average<TSource>(this IIterable<TSource> source, Func<TSource, int> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Average(source.AsEnumerable(), selector);
        }

        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				var value = selector (element);
				if (!value.HasValue)
					continue;

				total = total + value.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / (double) counter);
		}

		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			long count = 0;
			foreach (var element in source){
				total = checked (total + selector (element));
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / (double) count;

		}

        public static double Average<TSource>(this IIterable<TSource> source, Func<TSource, long> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Average(source.AsEnumerable(), selector);
        }

        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				var value = selector (element);
				if (!value.HasValue)
					continue;

				total = checked (total + value.Value);
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / (double) counter);
		}

		public static double Average<TSource> (this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			Check.SourceAndSelector (source, selector);

			double total = 0;
			long count = 0;
			foreach (var element in source){
				total += selector (element);
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;

		}

        public static double Average<TSource>(this IIterable<TSource> source, Func<TSource, double> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Average(source.AsEnumerable(), selector);
        }

        public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			Check.SourceAndSelector (source, selector);

			double total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				var value = selector (element);
				if (!value.HasValue)
					continue;

				total = total + value.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new double? (total / counter);

		}

		public static float Average<TSource> (this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			Check.SourceAndSelector (source, selector);

			float total = 0;
			long count = 0;
			foreach (var element in source){
				total += selector (element);
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;
		}

        public static double Average<TSource>(this IIterable<TSource> source, Func<TSource, float> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Average(source.AsEnumerable(), selector);
        }

        public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			Check.SourceAndSelector (source, selector);

			float total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				var value = selector (element);
				if (!value.HasValue)
					continue;

				total = total + value.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new float? (total / counter);
		}

		public static decimal Average<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			Check.SourceAndSelector (source, selector);

			decimal total = 0;
			long count = 0;
			foreach (var element in source){
				total += selector (element);
				count++;
			}
			if (count == 0)
				throw new InvalidOperationException ();
			return total / count;
		}

		public static decimal? Average<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			Check.SourceAndSelector (source, selector);

			decimal total = 0;
			long counter = 0;
			
			foreach (var element in source) {
				var value = selector (element);
				if (!value.HasValue)
					continue;

				total = total + value.Value;
				counter++;
			}

			if (counter == 0)
				return null;

			return new decimal? (total / counter);
		}

		#endregion

		#region Cast

		public static IEnumerable<TResult> Cast<TResult> (this IEnumerable source)
		{
			Check.Source (source);

			var actual = source as IEnumerable<TResult>;
			if (actual != null)
				return actual;

			return CreateCastIterator<TResult> (source);
		}

        public static IEnumerable<TResult> Cast<TSource, TResult>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return CreateCastIterator<TResult>(source.AsEnumerable());
        }

        static IEnumerable<TResult> CreateCastIterator<TResult>(IEnumerable source)
		{
			foreach (TResult element in source)
				yield return element;
		}

		#endregion

		#region Concat

		public static IEnumerable<TSource> Concat<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			Check.FirstAndSecond (first, second);

			return CreateConcatIterator (first, second);
		}

        public static IEnumerable<TSource> Concat<TSource>(this IIterable<TSource> first, IIterable<TSource> second)
        {
            Check.FirstAndSecond(first, second);

            return CreateConcatIterator(first.AsEnumerable(), second.AsEnumerable());
        }

        static IEnumerable<TSource> CreateConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			foreach (TSource element in first)
				yield return element;
			foreach (TSource element in second)
				yield return element;
		}

		#endregion

		#region Contains

		public static bool Contains<TSource> (this IEnumerable<TSource> source, TSource value)
		{
			var collection = source as Collections.Generic.ICollection<TSource>;
			if (collection != null)
				return collection.Contains (value);

			return Contains<TSource> (source, value, null);
		}

        public static bool Contains<TSource>(this IIterable<TSource> source, TSource value)
        {
            var collection = source as Java.Util.ICollection<TSource>;
            if (collection != null)
                return collection.Contains(value);

            return Contains<TSource>(source, value, null);
        }

        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			Check.Source (source);

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			foreach (var element in source)
				if (comparer.Equals (element, value))
					return true;

			return false;
		}

        public static bool Contains<TSource>(this IIterable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            Check.Source(source);
            return source.AsEnumerable().Contains(value, comparer);
        }

        #endregion

		#region Count

		public static int Count<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var collection = source as Collections.Generic.ICollection<TSource>;
			if (collection != null)
				return collection.Count;

			int counter = 0;
			using (var enumerator = source.GetEnumerator ())
				while (enumerator.MoveNext ())
					checked { counter++; }

			return counter;
		}

        public static int Count<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            var collection = source as Java.Util.ICollection<TSource>;
            if (collection != null)
                return collection.Size();

            return source.AsEnumerable().Count();
        }

        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndSelector (source, predicate);

			int counter = 0;
			foreach (var element in source)
				if (predicate (element))
					checked { counter++; }

			return counter;
		}

        public static int Count<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndSelector(source, predicate);
            return source.AsEnumerable().Count(predicate);
        }

        #endregion

		#region DefaultIfEmpty

		public static IEnumerable<TSource> DefaultIfEmpty<TSource> (this IEnumerable<TSource> source)
		{
			return DefaultIfEmpty (source, default (TSource));
		}

        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IIterable<TSource> source)
        {
            return DefaultIfEmpty(source, default(TSource));
        }

        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue)
		{
			Check.Source (source);

			return CreateDefaultIfEmptyIterator (source, defaultValue);
		}

        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IIterable<TSource> source, TSource defaultValue)
        {
            Check.Source(source);

            return CreateDefaultIfEmptyIterator(source.AsEnumerable(), defaultValue);
        }

        static IEnumerable<TSource> CreateDefaultIfEmptyIterator<TSource>(IEnumerable<TSource> source, TSource defaultValue)
		{
			bool empty = true;
			foreach (TSource item in source) {
				empty = false;
				yield return item;
			}

			if (empty)
				yield return defaultValue;
		}

		#endregion

		#region Distinct

		public static IEnumerable<TSource> Distinct<TSource> (this IEnumerable<TSource> source)
		{
			return Distinct<TSource> (source, null);
		}

        public static IEnumerable<TSource> Distinct<TSource>(this IIterable<TSource> source)
        {
            return Distinct<TSource>(source, null);
        }

        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			Check.Source (source);

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			return CreateDistinctIterator (source, comparer);
		}

        public static IEnumerable<TSource> Distinct<TSource>(this IIterable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            Check.Source(source);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateDistinctIterator(source.AsEnumerable(), comparer);
        }

        static IEnumerable<TSource> CreateDistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			var items = new Collections.Generic.HashSet<TSource> (comparer);
			foreach (var element in source) {
				if (! items.Contains (element)) {
					items.Add (element);
					yield return element;
				}
			}
		}

		#endregion

		#region ElementAt

		static TSource ElementAt<TSource> (this IEnumerable<TSource> source, int index, Fallback fallback)
		{
			long counter = 0L;

			foreach (var element in source) {
				if (index == counter++)
					return element;
			}

			if (fallback == Fallback.Throw)
				throw new ArgumentOutOfRangeException ();

			return default (TSource);
		}

		public static TSource ElementAt<TSource> (this IEnumerable<TSource> source, int index)
		{
			Check.Source (source);

			if (index < 0)
				throw new ArgumentOutOfRangeException ();

			var list = source as Collections.Generic.IList<TSource>;
			if (list != null)
				return list [index];

			return source.ElementAt (index, Fallback.Throw);
		}

        public static TSource ElementAt<TSource>(this IIterable<TSource> source, int index)
        {
            Check.Source(source);

            if (index < 0)
                throw new ArgumentOutOfRangeException();

            var list = source as Java.Util.IList<TSource>;
            if (list != null)
                return list[index];

            return source.AsEnumerable().ElementAt(index, Fallback.Throw);
        }

        #endregion

		#region ElementAtOrDefault

		public static TSource ElementAtOrDefault<TSource> (this IEnumerable<TSource> source, int index)
		{
			Check.Source (source);

			if (index < 0)
				return default (TSource);

			var list = source as Collections.Generic.IList<TSource>;
			if (list != null)
				return index < list.Count ? list [index] : default (TSource);

			return source.ElementAt (index, Fallback.Default);
		}

        public static TSource ElementAtOrDefault<TSource>(this IIterable<TSource> source, int index)
        {
            Check.Source(source);

            if (index < 0)
                return default(TSource);

            var list = source as Java.Util.IList<TSource>;
            if (list != null)
                return index < list.Size() ? list[index] : default(TSource);

            return source.AsEnumerable().ElementAt(index, Fallback.Default);
        }

        #endregion

		#region Empty

		public static IEnumerable<TResult> Empty<TResult> ()
		{
			return EmptyOf<TResult>.Instance();
		}

		#endregion

		#region Except

		public static IEnumerable<TSource> Except<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Except (first, second, null);
		}

        public static IEnumerable<TSource> Except<TSource>(this IIterable<TSource> first, IIterable<TSource> second)
        {
            return Except(first, second, null);
        }

        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            Check.FirstAndSecond(first, second);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateExceptIterator(first, second, comparer);
        }

        public static IEnumerable<TSource> Except<TSource>(this IIterable<TSource> first, IIterable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            Check.FirstAndSecond(first, second);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateExceptIterator(first.AsEnumerable(), second.AsEnumerable(), comparer);
        }

        static IEnumerable<TSource> CreateExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            var items = new Collections.Generic.HashSet<TSource>(second, comparer);
            foreach (var element in first)
            {
                if (items.Add(element))
                    yield return element;
            }
        }

		#endregion

		#region First

		static TSource First<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate, Fallback fallback)
		{
			foreach (var element in source)
				if (predicate (element))
					return element;

			if (fallback == Fallback.Throw)
				throw new InvalidOperationException ();

			return default (TSource);
		}

		public static TSource First<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var list = source as Collections.Generic.IList<TSource>;
			if (list != null) {
				if (list.Count != 0)
					return list [0];
			} else {
				using (var enumerator = source.GetEnumerator ()) {
					if (enumerator.MoveNext ())
						return enumerator.Current;
				}
			}

			throw new InvalidOperationException ("The source sequence is empty");
		}

        public static TSource First<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return source.AsEnumerable().First();
        }

        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.First (predicate, Fallback.Throw);
		}

        public static TSource First<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return source.AsEnumerable().First(predicate, Fallback.Throw);
        }

        #endregion

		#region FirstOrDefault

		public static TSource FirstOrDefault<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			return source.First (PredicateOf<TSource>.Always, Fallback.Default);
		}

        public static TSource FirstOrDefault<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return source.AsEnumerable().First(PredicateOf<TSource>.Always, Fallback.Default);
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.First (predicate, Fallback.Default);
		}

        public static TSource FirstOrDefault<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return source.AsEnumerable().First(predicate, Fallback.Default);
        }

        #endregion

		#region GroupBy

        //private static List<T> ContainsGroup<K, T> (
        //        LinkedHashMap<K, List<T>> items, K key, IEqualityComparer<K> comparer)
        //{
        //    IEqualityComparer<K> comparerInUse = (comparer ?? EqualityComparer<K>.Default);
        //    foreach (KeyValuePair<K, List<T>> value in items) {
        //        if (comparerInUse.Equals (value.Key, key))
        //            return value.Value;
        //    }
        //    return null;
        //}

		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey> (this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector)
		{
			return GroupBy<TSource, TKey> (source, keySelector, null);
		}

        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            return GroupBy<TSource, TKey>(source, keySelector, null);
        }

        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			Check.SourceAndKeySelector (source, keySelector);

			return CreateGroupByIterator (source, keySelector, comparer);
		}

        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            Check.SourceAndKeySelector(source, keySelector);

            return CreateGroupByIterator(source.AsEnumerable(), keySelector, comparer);
        }

        static IEnumerable<IGrouping<TKey, TSource>> CreateGroupByIterator<TSource, TKey>(this IEnumerable<TSource> source,
			                                                Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
            List<TKey> groupOrder = new List<TKey>();
            var groups = new Collections.Generic.Dictionary<TKey, List<TSource>>(comparer ?? EqualityComparer<TKey>.Default);

			var nullList = new List<TSource> ();
            int nullListIdx = -1;

			foreach (TSource element in source) 
            {
				TKey key = keySelector (element);

				if (key == null)
				{
				    if (nullList.Count == 0)
				        nullListIdx = groupOrder.Count;
					nullList.Add (element);
				} 
                else
                {
					List<TSource> group;
				    if(!groups.TryGetValue(key, out group))
                    { 
						group = new List<TSource> ();
						groups.Add (key, group);
                        groupOrder.Add(key);
					}
					group.Add (element);
				}
			}

            int idx = 0;
			foreach (var groupKey in groupOrder)
            {
                if(idx == nullListIdx)
                    yield return new Grouping<TKey, TSource>(default(TKey), nullList);

                yield return new Grouping<TKey, TSource> (groupKey, groups[groupKey]);

                ++idx;
            }

            if (idx == nullListIdx)
                yield return new Grouping<TKey, TSource>(default(TKey), nullList);
		}

		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement> (this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return GroupBy<TSource, TKey, TElement> (source, keySelector, elementSelector, null);
		}

        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
        }

        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Check.SourceAndKeyElementSelectors (source, keySelector, elementSelector);

			return CreateGroupByIterator (source, keySelector, elementSelector, comparer);
		}

        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            Check.SourceAndKeyElementSelectors(source, keySelector, elementSelector);

            return CreateGroupByIterator(source.AsEnumerable(), keySelector, elementSelector, comparer);
        }

        static IEnumerable<IGrouping<TKey, TElement>> CreateGroupByIterator<TSource, TKey, TElement>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
            List<TKey> groupOrder = new List<TKey>();
            var groups = new Collections.Generic.Dictionary<TKey, List<TElement>>(comparer ?? EqualityComparer<TKey>.Default);

            var nullList = new List<TElement>();
            int nullListIdx = -1;

            foreach (TSource value in source)
            {
                TKey key = keySelector(value);
                TElement element = elementSelector(value);

                if (key == null)
                {
                    if (nullList.Count == 0)
                        nullListIdx = groupOrder.Count;
                    nullList.Add(element);
                }
                else
                {
                    List<TElement> group;
                    if (!groups.TryGetValue(key, out group))
                    {
                        group = new List<TElement>();
                        groups.Add(key, group);
                        groupOrder.Add(key);
                    }
                    group.Add(element);
                }
            }

            int idx = 0;
            foreach (var groupKey in groupOrder)
            {
                if (idx == nullListIdx)
                    yield return new Grouping<TKey, TElement>(default(TKey), nullList);

                yield return new Grouping<TKey, TElement>(groupKey, groups[groupKey]);

                ++idx;
            }

            if (idx == nullListIdx)
                yield return new Grouping<TKey, TElement>(default(TKey), nullList);
		}

		public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult> (this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			return GroupBy (source, keySelector, elementSelector, resultSelector, null);
		}

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            return GroupBy(source, keySelector, elementSelector, resultSelector, null);
        }

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			Check.GroupBySelectors (source, keySelector, elementSelector, resultSelector);

			return CreateGroupByIterator (source, keySelector, elementSelector, resultSelector, comparer);
		}

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            Check.GroupBySelectors(source, keySelector, elementSelector, resultSelector);

            return CreateGroupByIterator(source.AsEnumerable(), keySelector, elementSelector, resultSelector, comparer);
        }

        static IEnumerable<TResult> CreateGroupByIterator<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector,
			Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			IEnumerable<IGrouping<TKey, TElement>> groups = GroupBy<TSource, TKey, TElement> (
				source, keySelector, elementSelector, comparer);

			foreach (IGrouping<TKey, TElement> group in groups)
				yield return resultSelector (group.Key, group);
		}

		public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult> (this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector,
			Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
		{
			return GroupBy (source, keySelector, resultSelector, null);
		}

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
            return GroupBy(source, keySelector, resultSelector, null);
        }

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector,
			Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			Check.SourceAndKeyResultSelectors (source, keySelector, resultSelector);

			return CreateGroupByIterator (source, keySelector, resultSelector, comparer);
		}

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            Check.SourceAndKeyResultSelectors(source, keySelector, resultSelector);

            return CreateGroupByIterator(source.AsEnumerable(), keySelector, resultSelector, comparer);
        }

        static IEnumerable<TResult> CreateGroupByIterator<TSource, TKey, TResult>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector,
			Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			IEnumerable<IGrouping<TKey,TSource>> groups = GroupBy<TSource, TKey> (source, keySelector, comparer);

			foreach (IGrouping<TKey, TSource> group in groups)
				yield return resultSelector (group.Key, group);
		}

		#endregion

		# region GroupJoin

		public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult> (this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
		{
			return GroupJoin (outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IIterable<TOuter> outer,
            IIterable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            Check.JoinSelectors(outer, inner, outerKeySelector, innerKeySelector, resultSelector);
            return GroupJoin(outer.AsEnumerable(), inner.AsEnumerable(), outerKeySelector, innerKeySelector, resultSelector, null);
        }

        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			Check.JoinSelectors (outer, inner, outerKeySelector, innerKeySelector, resultSelector);

			if (comparer == null)
				comparer = EqualityComparer<TKey>.Default;

			return CreateGroupJoinIterator (outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
		}

        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IIterable<TOuter> outer,
            IIterable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey> comparer)
        {
            Check.JoinSelectors(outer, inner, outerKeySelector, innerKeySelector, resultSelector);

            if (comparer == null)
                comparer = EqualityComparer<TKey>.Default;

            return CreateGroupJoinIterator(outer.AsEnumerable(), inner.AsEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        static IEnumerable<TResult> CreateGroupJoinIterator<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
			IEqualityComparer<TKey> comparer)
		{
			ILookup<TKey, TInner> innerKeys = ToLookup<TInner, TKey> (inner, innerKeySelector, comparer);
			/*Dictionary<K, List<U>> innerKeys = new Dictionary<K, List<U>> ();
			foreach (U element in inner)
			{
					K innerKey = innerKeySelector (element);
					if (!innerKeys.ContainsKey (innerKey))
							innerKeys.Add (innerKey, new List<U> ());
					innerKeys[innerKey].Add (element);
			}*/

			foreach (TOuter element in outer) {
				TKey outerKey = outerKeySelector (element);
				if (innerKeys.Contains (outerKey))
					yield return resultSelector (element, innerKeys [outerKey]);
				else
					yield return resultSelector (element, Empty<TInner> ());
			}
		}

		#endregion

		#region Intersect

		public static IEnumerable<TSource> Intersect<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return Intersect (first, second, null);
		}

        public static IEnumerable<TSource> Intersect<TSource>(this IIterable<TSource> first, IIterable<TSource> second)
        {
            Check.FirstAndSecond(first, second);
            return Intersect(first.AsEnumerable(), second.AsEnumerable(), null);
        }

        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			Check.FirstAndSecond (first, second);

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			return CreateIntersectIterator (first, second, comparer);
		}

        public static IEnumerable<TSource> Intersect<TSource>(this IIterable<TSource> first, IIterable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            Check.FirstAndSecond(first, second);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateIntersectIterator(first.AsEnumerable(), second.AsEnumerable(), comparer);
        }

        static IEnumerable<TSource> CreateIntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			var items = new Collections.Generic.HashSet<TSource> (second, comparer);
			foreach (TSource element in first) {
				if (items.Remove (element))
					yield return element;
			}
		}

		#endregion

		# region Join

		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult> (this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			Check.JoinSelectors (outer, inner, outerKeySelector, innerKeySelector, resultSelector);

			if (comparer == null)
				comparer = EqualityComparer<TKey>.Default;

			return CreateJoinIterator (outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
		}

        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IIterable<TOuter> outer,
            IIterable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            Check.JoinSelectors(outer, inner, outerKeySelector, innerKeySelector, resultSelector);

            if (comparer == null)
                comparer = EqualityComparer<TKey>.Default;

            return CreateJoinIterator(outer.AsEnumerable(), inner.AsEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }

        static IEnumerable<TResult> CreateJoinIterator<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			ILookup<TKey, TInner> innerKeys = ToLookup<TInner, TKey> (inner, innerKeySelector, comparer);
			/*Dictionary<K, List<U>> innerKeys = new Dictionary<K, List<U>> ();
			foreach (U element in inner)
			{
					K innerKey = innerKeySelector (element);
					if (!innerKeys.ContainsKey (innerKey))
							innerKeys.Add (innerKey, new List<U> ());
					innerKeys[innerKey].Add (element);
			}*/

			foreach (TOuter element in outer) {
				TKey outerKey = outerKeySelector (element);
				if (innerKeys.Contains (outerKey)) {
					foreach (TInner innerElement in innerKeys [outerKey])
						yield return resultSelector (element, innerElement);
				}
			}
		}

		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult> (this IEnumerable<TOuter> outer,
			IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
			Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return outer.Join (inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IIterable<TOuter> outer,
            IIterable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer.AsEnumerable().Join(inner.AsEnumerable(), outerKeySelector, innerKeySelector, resultSelector, null);
        }

		#endregion

		#region Last

		static TSource Last<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate, Fallback fallback)
		{
			var empty = true;
			var item = default (TSource);

			foreach (var element in source) {
				if (!predicate (element))
					continue;

				item = element;
				empty = false;
			}

			if (!empty)
				return item;

			if (fallback == Fallback.Throw)
				throw new InvalidOperationException ();

			return item;
		}

		public static TSource Last<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var collection = source as Collections.Generic.ICollection<TSource>;
			if (collection != null && collection.Count == 0)
				throw new InvalidOperationException ();

			var list = source as Collections.Generic.IList<TSource>;
			if (list != null)
				return list [list.Count - 1];

			return source.Last (PredicateOf<TSource>.Always, Fallback.Throw);
		}

        public static TSource Last<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Last();
        }

        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.Last (predicate, Fallback.Throw);
		}

        public static TSource Last<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return source.Last(predicate);
        }

        #endregion

		#region LastOrDefault

		public static TSource LastOrDefault<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var list = source as Collections.Generic.IList<TSource>;
			if (list != null)
				return list.Count > 0 ? list [list.Count - 1] : default (TSource);

			return source.Last (PredicateOf<TSource>.Always, Fallback.Default);
		}

        public static TSource LastOrDefault<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return source.AsEnumerable().LastOrDefault();
        }

        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.Last (predicate, Fallback.Default);
		}

        public static TSource LastOrDefault<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);
            return source.AsEnumerable().LastOrDefault(predicate);
        }

		#endregion

		#region LongCount

		public static long LongCount<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

#if !NET_2_1
			var array = source as TSource [];
			if (array != null)
				return array.Length;
#endif

			long counter = 0;
			using (var enumerator = source.GetEnumerator ())
				while (enumerator.MoveNext ())
					counter++;

			return counter;
		}

	    public static long LongCount<TSource>(this IIterable<TSource> source)
	    {
	        Check.Source(source);
	        return source.AsEnumerable().LongCount();
	    }

	    public static long LongCount<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndSelector (source, predicate);

			long counter = 0;
			foreach (TSource element in source)
				if (predicate (element))
					counter++;

			return counter;
		}

        public static long LongCount<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndSelector(source, predicate);
            return source.AsEnumerable().LongCount(predicate);
        }

        #endregion

		#region Max

		public static int Max (this IEnumerable<int> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = int.MinValue;
			foreach (var element in source){
				max = Math.Max (element, max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

	    public static int Max(this IIterable<int> source)
	    {
	        Check.Source(source);
	        return source.AsEnumerable().Max();
	    }

	    public static long Max (this IEnumerable<long> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = long.MinValue;
			foreach (var element in source){
				max = Math.Max (element, max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static long Max(this IIterable<long> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Max();
        }

		public static double Max (this IEnumerable<double> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = double.MinValue;
			foreach (var element in source){
				max = Math.Max (element, max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static double Max(this IIterable<double> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Max();
        }

		public static float Max (this IEnumerable<float> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = float.MinValue;
			foreach (var element in source){
				max = Math.Max (element, max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static float Max(this IIterable<float> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Max();
        }

		public static decimal Max (this IEnumerable<decimal> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = decimal.MinValue;
			foreach (var element in source){
				max = Math.Max (element, max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

		public static int? Max (this IEnumerable<int?> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = int.MinValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				max = Math.Max (element.Value, max);
				empty = false;
			}

			if (empty)
				return null;

			return max;
		}

		public static long? Max (this IEnumerable<long?> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = long.MinValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				max = Math.Max (element.Value, max);
				empty = false;
			}

			if (empty)
				return null;

			return max;
		}

		public static double? Max (this IEnumerable<double?> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = double.MinValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				max = Math.Max (element.Value, max);
				empty = false;
			}

			if (empty)
				return null;

			return max;
		}

		public static float? Max (this IEnumerable<float?> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = float.MinValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				max = Math.Max (element.Value, max);
				empty = false;
			}

			if (empty)
				return null;

			return max;
		}

		public static decimal? Max (this IEnumerable<decimal?> source)
		{
			Check.Source (source);

			bool empty = true;
			var max = decimal.MinValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				max = Math.Max (element.Value, max);
				empty = false;
			}

			if (empty)
				return null;

			return max;
		}

		// TODO: test nullable and non-nullable
		public static TSource Max<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var comparer = Comparer<TSource>.Default;

			TSource max = default (TSource);
			
			if (default (TSource) == null){
				foreach (var element in source) {
					if (element == null)
						continue;

					if (max == null || comparer.Compare (element, max) > 0)
						max = element;
				}
			} else {
				bool empty = true;
				foreach (var element in source) {
					if (empty){
						max = element;
						empty = false;
						continue;
					}
					if (comparer.Compare (element, max) > 0)
						max = element;
				}
				if (empty)
					throw new InvalidOperationException ();
			}
			return max;
		}

        public static TSource Max<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Max();
        }

		public static int Max<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var max = int.MinValue;
			foreach (var element in source){
				max = Math.Max (selector (element), max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static int Max<TSource>(this IIterable<TSource> source, Func<TSource, int> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Max(selector);
        }

        public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var max = long.MinValue;
			foreach (var element in source){
				max = Math.Max (selector (element), max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static long Max<TSource>(this IIterable<TSource> source, Func<TSource, long> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Max(selector);
        }

        public static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var max = double.MinValue;
			foreach (var element in source){
				max = Math.Max (selector (element), max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static double Max<TSource>(this IIterable<TSource> source, Func<TSource, double> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Max(selector);
        }

        public static float Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var max = float.MinValue;
			foreach (var element in source){
				max = Math.Max (selector (element), max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

        public static float Max<TSource>(this IIterable<TSource> source, Func<TSource, float> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Max(selector);
        }

        public static decimal Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var max = decimal.MinValue;
			foreach (var element in source){
				max = Math.Max (selector (element), max);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return max;
		}

		static U Iterate<T, U> (IEnumerable<T> source, U initValue, Func<T, U, U> selector)
		{
			bool empty = true;
			foreach (var element in source) {
				initValue = selector (element, initValue);
				empty = false;
			}

			if (empty)
				throw new InvalidOperationException ();

			return initValue;
		}

		public static int? Max<TSource> (this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			int? max = null;
			foreach (var element in source) {
				int? item = selector (element);

				if (!max.HasValue)
					max = item;
				else if (item > max)
					max = item;
				empty = false;
			}

			if (empty)
				return null;
			return max;
		}

		public static long? Max<TSource> (this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			long? max = null;
			foreach (var element in source) {
				long? item = selector (element);

				if (!max.HasValue)
					max = item;
				else if (item > max)
					max = item;
				empty = false;
			}

			if (empty)
				return null;
			return max;
		}

		public static double? Max<TSource> (this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			double? max = null;
			foreach (var element in source) {
				double? item = selector (element);

				if (!max.HasValue)
					max = item;
				else if (item > max)
					max = item;
				empty = false;
			}

			if (empty)
				return null;
			return max;
		}

		public static float? Max<TSource> (this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			float? max = null;
			foreach (var element in source) {
				float? item = selector (element);

				if (!max.HasValue)
					max = item;
				else if (item > max)
					max = item;
				empty = false;
			}

			if (empty)
				return null;
			return max;
		}

		public static decimal? Max<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			decimal? max = null;
			foreach (var element in source) {
				decimal? item = selector (element);

				if (!max.HasValue)
					max = item;
				else if (item > max)
					max = item;
				empty = false;
			}

			if (empty)
				return null;
			return max;
		}

		public static TResult Max<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			Check.SourceAndSelector (source, selector);

			// TODO: inline
			return source.Select (selector).Max ();
		}

        public static TResult Max<TSource, TResult>(this IIterable<TSource> source, Func<TSource, TResult> selector)
        {
            Check.SourceAndSelector(source, selector);
            return source.AsEnumerable().Max(selector);
        }

        #endregion

		#region Min

		public static int Min (this IEnumerable<int> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = int.MaxValue;
			foreach (var element in source){
				min = Math.Min (element, min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

	    public static int Min(this IIterable<int> source)
	    {
	        Check.Source(source);
	        return source.AsEnumerable().Min();
	    }

	    public static long Min (this IEnumerable<long> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = long.MaxValue;
			foreach (var element in source){
				min = Math.Min (element, min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static long Min(this IIterable<long> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Min();
        }

        public static double Min(this IEnumerable<double> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = double.MaxValue;
			foreach (var element in source){
				min = Math.Min (element, min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static double Min(this IIterable<double> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Min();
        }

        public static float Min(this IEnumerable<float> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = float.MaxValue;
			foreach (var element in source){
				min = Math.Min (element, min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static float Min(this IIterable<float> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Min();
        }

        public static decimal Min(this IEnumerable<decimal> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = decimal.MaxValue;
			foreach (var element in source){
				min = Math.Min (element, min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

		public static int? Min (this IEnumerable<int?> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = int.MaxValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				min = Math.Min (element.Value, min);
				empty = false;
			}

			if (empty)
				return null;

			return min;
		}

		public static long? Min (this IEnumerable<long?> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = long.MaxValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				min = Math.Min (element.Value, min);
				empty = false;
			}

			if (empty)
				return null;

			return min;
		}

		public static double? Min (this IEnumerable<double?> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = double.MaxValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				min = Math.Min (element.Value, min);
				empty = false;
			}

			if (empty)
				return null;

			return min;
		}

		public static float? Min (this IEnumerable<float?> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = float.MaxValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				min = Math.Min (element.Value, min);
				empty = false;
			}

			if (empty)
				return null;

			return min;
		}

		public static decimal? Min (this IEnumerable<decimal?> source)
		{
			Check.Source (source);

			bool empty = true;
			var min = decimal.MaxValue;
				
			foreach (var element in source) {
				if (!element.HasValue)
					continue;

				min = Math.Min (element.Value, min);
				empty = false;
			}

			if (empty)
				return null;

			return min;
		}

		public static TSource Min<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			var comparer = Comparer<TSource>.Default;

			TSource min = default (TSource);
			
			if (default (TSource) == null){
				foreach (var element in source) {
					if (element == null)
						continue;

					if (min == null || comparer.Compare (element, min) < 0)
						min = element;
				}
			} else {
				bool empty = true;
				foreach (var element in source) {
					if (empty){
						min = element;
						empty = false;
						continue;
					}
					if (comparer.Compare (element, min) < 0)
						min = element;
				}
				if (empty)
					throw new InvalidOperationException ();
			}
			return min;
		}

        public static TSource Min<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);
            return source.AsEnumerable().Min();
        }

		public static int Min<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var min = int.MaxValue;
			foreach (var element in source){
				min = Math.Min (selector (element), min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static int Min<TSource>(this IIterable<TSource> source, Func<TSource, int> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Min(selector);
        }

		public static long Min<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var min = long.MaxValue;
			foreach (var element in source){
				min = Math.Min (selector (element), min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static long Min<TSource>(this IIterable<TSource> source, Func<TSource, long> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Min(selector);
        }

        public static double Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var min = double.MaxValue;
			foreach (var element in source){
				min = Math.Min (selector (element), min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static double Min<TSource>(this IIterable<TSource> source, Func<TSource, double> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Min(selector);
        }

        public static float Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var min = float.MaxValue;
			foreach (var element in source){
				min = Math.Min (selector (element), min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

        public static float Min<TSource>(this IIterable<TSource> source, Func<TSource, float> selector)
        {
            Check.Source(source);
            return source.AsEnumerable().Min(selector);
        }

        public static decimal Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			var min = decimal.MaxValue;
			foreach (var element in source){
				min = Math.Min (selector (element), min);
				empty = false;
			}
			if (empty)
				throw new InvalidOperationException ();
			return min;
		}

		public static int? Min<TSource> (this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			int? min = null;
			foreach (var element in source) {
				int? item = selector (element);

				if (!min.HasValue)
					min = item;
				else if (item < min)
					min = item;
				empty = false;
			}

			if (empty)
				return null;
			return min;
		}

		public static long? Min<TSource> (this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			long? min = null;
			foreach (var element in source) {
				long? item = selector (element);

				if (!min.HasValue)
					min = item;
				else if (item < min)
					min = item;
				empty = false;
			}

			if (empty)
				return null;
			return min;
		}

		public static float? Min<TSource> (this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			float? min = null;
			foreach (var element in source) {
				float? item = selector (element);

				if (!min.HasValue)
					min = item;
				else if (item < min)
					min = item;
				empty = false;
			}

			if (empty)
				return null;
			return min;
		}

		public static double? Min<TSource> (this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			double? min = null;
			foreach (var element in source) {
				double? item = selector (element);

				if (!min.HasValue)
					min = item;
				else if (item < min)
					min = item;
				empty = false;
			}

			if (empty)
				return null;
			return min;
		}

		public static decimal? Min<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			Check.SourceAndSelector (source, selector);

			bool empty = true;
			decimal? min = null;
			foreach (var element in source) {
				decimal? item = selector (element);

				if (!min.HasValue)
					min = item;
				else if (item < min)
					min = item;
				empty = false;
			}

			if (empty)
				return null;
			return min;
		}

		public static TResult Min<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			Check.SourceAndSelector (source, selector);

			// TODO: inline
			return source.Select (selector).Min ();
		}

        public static TResult Min<TSource, TResult>(this IIterable<TSource> source, Func<TSource, TResult> selector)
        {
            Check.SourceAndSelector(source, selector);
            return source.AsEnumerable().Min(selector);
        }

        #endregion

		#region OfType

		public static IEnumerable<TResult> OfType<TResult> (this IEnumerable source)
		{
			Check.Source (source);

			return CreateOfTypeIterator<TResult> (source);
		}

        public static IEnumerable<TResult> OfType<TSource, TResult>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return CreateOfTypeIterator<TResult>(source.AsEnumerable());
        }

        static IEnumerable<TResult> CreateOfTypeIterator<TResult>(IEnumerable source)
		{
			foreach (object element in source)
				if (element is TResult)
					yield return (TResult) element;
		}

		#endregion

		#region OrderBy

		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector)
		{
			return OrderBy<TSource, TKey> (source, keySelector, null);
		}

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IIterable<TSource> source,
                Func<TSource, TKey> keySelector)
        {
            return OrderBy<TSource, TKey>(source.AsEnumerable(), keySelector, null);
        }

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector,
				IComparer<TKey> comparer)
		{
			Check.SourceAndKeySelector (source, keySelector);

			return new OrderedSequence<TSource, TKey> (source, keySelector, comparer, SortDirection.Ascending);
		}

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IIterable<TSource> source,
                Func<TSource, TKey> keySelector,
                IComparer<TKey> comparer)
        {
            Check.SourceAndKeySelector(source, keySelector);
            return OrderBy(source.AsEnumerable(), keySelector, comparer);
        }

		#endregion

		#region OrderByDescending

		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector)
		{
			return OrderByDescending<TSource, TKey> (source, keySelector, null);
		}

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IIterable<TSource> source,
                Func<TSource, TKey> keySelector)
        {
            return OrderByDescending(source.AsEnumerable(), keySelector, null);
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Check.SourceAndKeySelector (source, keySelector);

			return new OrderedSequence<TSource, TKey> (source, keySelector, comparer, SortDirection.Descending);
		}

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IIterable<TSource> source,
                Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            Check.SourceAndKeySelector(source, keySelector);
            return OrderByDescending(source.AsEnumerable(), keySelector, comparer);
        }

        #endregion

		#region Range

		public static IEnumerable<int> Range (int start, int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException ("count");

			if (((long) start + count) - 1L > int.MaxValue)
				throw new ArgumentOutOfRangeException ();

			return CreateRangeIterator (start, count);
		}

		static IEnumerable<int> CreateRangeIterator (int start, int count)
		{
			for (int i = 0; i < count; i++)
				yield return start + i;
		}

		#endregion

		#region Repeat

		public static IEnumerable<TResult> Repeat<TResult> (TResult element, int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException ();

			return CreateRepeatIterator (element, count);
		}

        static IEnumerable<TResult> CreateRepeatIterator<TResult>(TResult element, int count)
		{
			for (int i = 0; i < count; i++)
				yield return element;
		}

		#endregion

		#region Reverse

		public static IEnumerable<TSource> Reverse<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			return CreateReverseIterator (source);
		}

        public static IEnumerable<TSource> Reverse<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return CreateReverseIterator(source.AsEnumerable());
        }

        static IEnumerable<TSource> CreateReverseIterator<TSource>(IEnumerable<TSource> source)
		{
			var array = source.ToArray ();

			for (int i = array.Length - 1; i >= 0; i--)
				yield return array [i];
		}

		#endregion

		#region Select

		public static IEnumerable<TResult> Select<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			Check.SourceAndSelector (source, selector);

			return CreateSelectIterator (source, selector);
		}

        public static IEnumerable<TResult> Select<TSource, TResult>(this IIterable<TSource> source, Func<TSource, TResult> selector)
        {
            Check.SourceAndSelector(source, selector);

            return CreateSelectIterator(source.AsEnumerable(), selector);
        }

        static IEnumerable<TResult> CreateSelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			foreach (var element in source)
				yield return selector (element);
		}

		public static IEnumerable<TResult> Select<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			Check.SourceAndSelector (source, selector);

			return CreateSelectIterator (source, selector);
		}

        public static IEnumerable<TResult> Select<TSource, TResult>(this IIterable<TSource> source, Func<TSource, int, TResult> selector)
        {
            Check.SourceAndSelector(source, selector);

            return CreateSelectIterator(source.AsEnumerable(), selector);
        }

        static IEnumerable<TResult> CreateSelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			int counter = 0;
			foreach (TSource element in source) {
				yield return selector (element, counter);
				counter++;
			}
		}

		#endregion

		#region SelectMany

		public static IEnumerable<TResult> SelectMany<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			Check.SourceAndSelector (source, selector);

			return CreateSelectManyIterator (source, selector);
		}

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IIterable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            Check.SourceAndSelector(source, selector);

            return CreateSelectManyIterator(source.AsEnumerable(), selector);
        }

        static IEnumerable<TResult> CreateSelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			foreach (TSource element in source)
				foreach (TResult item in selector (element))
					yield return item;
		}

		public static IEnumerable<TResult> SelectMany<TSource, TResult> (this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			Check.SourceAndSelector (source, selector);

			return CreateSelectManyIterator (source, selector);
		}

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IIterable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
            Check.SourceAndSelector(source, selector);

            return CreateSelectManyIterator(source.AsEnumerable(), selector);
        }

        static IEnumerable<TResult> CreateSelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			int counter = 0;
			foreach (TSource element in source) {
				foreach (TResult item in selector (element, counter))
					yield return item;
				counter++;
			}
		}

		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult> (this IEnumerable<TSource> source,
			Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			Check.SourceAndCollectionSelectors (source, collectionSelector, resultSelector);

			return CreateSelectManyIterator (source, collectionSelector, resultSelector);
		}

        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IIterable<TSource> source,
            Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            Check.SourceAndCollectionSelectors(source, collectionSelector, resultSelector);

            return CreateSelectManyIterator(source.AsEnumerable(), collectionSelector, resultSelector);
        }

        static IEnumerable<TResult> CreateSelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source,
			Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> selector)
		{
			foreach (TSource element in source)
				foreach (TCollection collection in collectionSelector (element))
					yield return selector (element, collection);
		}

		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult> (this IEnumerable<TSource> source,
			Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			Check.SourceAndCollectionSelectors (source, collectionSelector, resultSelector);

			return CreateSelectManyIterator (source, collectionSelector, resultSelector);
		}

        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IIterable<TSource> source,
            Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            Check.SourceAndCollectionSelectors(source, collectionSelector, resultSelector);

            return CreateSelectManyIterator(source.AsEnumerable(), collectionSelector, resultSelector);
        }

        static IEnumerable<TResult> CreateSelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source,
			Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> selector)
		{
			int counter = 0;
			foreach (TSource element in source)
				foreach (TCollection collection in collectionSelector (element, counter++))
					yield return selector (element, collection);
		}

		#endregion

		#region Single

		static TSource Single<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate, Fallback fallback)
		{
			var found = false;
			var item = default (TSource);

			foreach (var element in source) {
				if (!predicate (element))
					continue;

				if (found)
					throw new InvalidOperationException ();

				found = true;
				item = element;
			}

			if (!found && fallback == Fallback.Throw)
				throw new InvalidOperationException ();

			return item;
		}

		public static TSource Single<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			return source.Single (PredicateOf<TSource>.Always, Fallback.Throw);
		}

        public static TSource Single<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return source.AsEnumerable().Single(PredicateOf<TSource>.Always, Fallback.Throw);
        }

        public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.Single (predicate, Fallback.Throw);
		}

        public static TSource Single<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return source.AsEnumerable().Single(predicate, Fallback.Throw);
        }

		#endregion

		#region SingleOrDefault

		public static TSource SingleOrDefault<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			return source.Single (PredicateOf<TSource>.Always, Fallback.Default);
		}

        public static TSource SingleOrDefault<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return source.AsEnumerable().Single(PredicateOf<TSource>.Always, Fallback.Default);
        }

        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return source.Single (predicate, Fallback.Default);
		}

        public static TSource SingleOrDefault<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return source.AsEnumerable().Single(predicate, Fallback.Default);
        }

        #endregion

		#region Skip

		public static IEnumerable<TSource> Skip<TSource> (this IEnumerable<TSource> source, int count)
		{
			Check.Source (source);

			return CreateSkipIterator (source, count);
		}

        public static IEnumerable<TSource> Skip<TSource>(this IIterable<TSource> source, int count)
        {
            Check.Source(source);

            return CreateSkipIterator(source.AsEnumerable(), count);
        }

        static IEnumerable<TSource> CreateSkipIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			var enumerator = source.GetEnumerator ();
			try {
				while (count-- > 0)
					if (!enumerator.MoveNext ())
						yield break;

				while (enumerator.MoveNext ())
					yield return enumerator.Current;

			} finally {
				enumerator.Dispose ();
			}
		}

		#endregion

		#region SkipWhile

		public static IEnumerable<TSource> SkipWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateSkipWhileIterator (source, predicate);
		}

        public static IEnumerable<TSource> SkipWhile<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateSkipWhileIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateSkipWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			bool yield = false;

			foreach (TSource element in source) {
				if (yield)
					yield return element;
				else
					if (!predicate (element)) {
						yield return element;
						yield = true;
					}
			}
		}

		public static IEnumerable<TSource> SkipWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateSkipWhileIterator (source, predicate);
		}

        public static IEnumerable<TSource> SkipWhile<TSource>(this IIterable<TSource> source, Func<TSource, int, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateSkipWhileIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateSkipWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			int counter = 0;
			bool yield = false;

			foreach (TSource element in source) {
				if (yield)
					yield return element;
				else
					if (!predicate (element, counter)) {
						yield return element;
						yield = true;
					}
				counter++;
			}
		}

		#endregion

		#region Sum

		public static int Sum (this IEnumerable<int> source)
		{
			Check.Source (source);
			int total = 0;
			
			foreach (var element in source)
				total = checked (total + element);
			return total;
		}

        public static int Sum(this IIterable<int> source)
        {
            Check.Source(source);
            return Sum(source.AsEnumerable());
        }

        public static int? Sum(this IEnumerable<int?> source)
		{
			Check.Source (source);

			int total = 0;
			foreach (var element in source) {
				if (element.HasValue)
					total = checked (total + element.Value);
			}
			return total;
		}

		public static int Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			Check.SourceAndSelector (source, selector);
			int total = 0;

			foreach (var element in source)
				total = checked (total + selector (element));

			return total;
		}

        public static int Sum<TSource>(this IIterable<TSource> source, Func<TSource, int> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Sum(source.AsEnumerable(), selector);
        }

        public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
		{
			Check.SourceAndSelector (source, selector);

			int total = 0;
			foreach (var element in source) {
				var value = selector (element);
				if (value.HasValue)
					total = checked (total + value.Value);
			}
			return total;
		}

		public static long Sum (this IEnumerable<long> source)
		{
			Check.Source (source);

			long total = 0;
			
			foreach (var element in source)
				total = checked (total + element);
			return total;
		}

        public static long Sum(this IIterable<long> source)
        {
            Check.Source(source);
            return Sum(source.AsEnumerable());
        }

        public static long? Sum(this IEnumerable<long?> source)
		{
			Check.Source (source);

			long total = 0;
			foreach (var element in source) {
				if (element.HasValue)
					total = checked (total + element.Value);
			}
			return total;
		}

		public static long Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			foreach (var element in source)
				total = checked (total + selector (element));
			return total;
		}

        public static long Sum<TSource>(this IIterable<TSource> source, Func<TSource, long> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Sum(source.AsEnumerable(), selector);
        }

        public static long? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
		{
			Check.SourceAndSelector (source, selector);

			long total = 0;
			foreach (var element in source) {
				var value = selector (element);
				if (value.HasValue)
					total = checked (total + value.Value);
			}
			return total;
		}

		public static double Sum (this IEnumerable<double> source)
		{
			Check.Source (source);

			double total = 0;
			
			foreach (var element in source)
				total = checked (total + element);
			return total;
		}

        public static double Sum(this IIterable<double> source)
        {
            Check.Source(source);
            return Sum(source.AsEnumerable());
        }

        public static double? Sum(this IEnumerable<double?> source)
		{
			Check.Source (source);

			double total = 0;
			foreach (var element in source) {
				if (element.HasValue)
					total = checked (total + element.Value);
			}
			return total;
		}

		public static double Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			Check.SourceAndSelector (source, selector);

			double total = 0;
			
			foreach (var element in source)
				total = checked (total + selector (element));
			return total;
		}

        public static double Sum<TSource>(this IIterable<TSource> source, Func<TSource, double> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Sum(source.AsEnumerable(), selector);
        }

        public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
		{
			Check.SourceAndSelector (source, selector);

			double total = 0;
			foreach (var element in source) {
				var value = selector (element);
				if (value.HasValue)
					total = checked (total + value.Value);
			}
			return total;
		}

		public static float Sum (this IEnumerable<float> source)
		{
			Check.Source (source);

			float total = 0;
			
			foreach (var element in source)
				total = checked (total + element);
			return total;
		}

        public static float Sum(this IIterable<float> source)
        {
            Check.Source(source);
            return Sum(source.AsEnumerable());
        }

        public static float? Sum(this IEnumerable<float?> source)
		{
			Check.Source (source);

			float total = 0;
			foreach (var element in source) {
				if (element.HasValue)
					total = checked (total + element.Value);
			}
			return total;

		}

		public static float Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			Check.SourceAndSelector (source, selector);
			float total = 0;
			foreach (var element in source)
				total = checked (total + selector (element));
			return total;
		}

        public static float Sum<TSource>(this IIterable<TSource> source, Func<TSource, float> selector)
        {
            Check.SourceAndSelector(source, selector);
            return Sum(source.AsEnumerable(), selector);
        }

        public static float? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
		{
			Check.SourceAndSelector (source, selector);

			float total = 0;
			foreach (var element in source) {
				var value = selector (element);
				if (value.HasValue)
					total = checked (total + value.Value);
			}
			return total;
		}

		public static decimal Sum (this IEnumerable<decimal> source)
		{
			Check.Source (source);
			decimal total = 0;
			
			foreach (var element in source)
				total = checked (total + element);
			return total;
		}

		public static decimal? Sum (this IEnumerable<decimal?> source)
		{
			Check.Source (source);

			decimal total = 0;
			foreach (var element in source) {
				if (element.HasValue)
					total = checked (total + element.Value);
			}
			return total;

		}

		public static decimal Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			Check.SourceAndSelector (source, selector);
			decimal total = 0;
			
			foreach (var element in source)
				total = checked (total + selector (element));
			return total;
		}

		public static decimal? Sum<TSource> (this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
		{
			Check.SourceAndSelector (source, selector);

			decimal total = 0;
			foreach (var element in source) {
				var value = selector (element);
				if (value.HasValue)
					total = checked (total + value.Value);
			}
			return total;
		}

		#endregion

		#region Take

		public static IEnumerable<TSource> Take<TSource> (this IEnumerable<TSource> source, int count)
		{
			Check.Source (source);

			return CreateTakeIterator (source, count);
		}

        public static IEnumerable<TSource> Take<TSource>(this IIterable<TSource> source, int count)
        {
            Check.Source(source);

            return CreateTakeIterator(source.AsEnumerable(), count);
        }

        static IEnumerable<TSource> CreateTakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			if (count <= 0)
				yield break;

			int counter = 0;
			foreach (TSource element in source) {
				yield return element;

				if (++counter == count)
					yield break;
			}
		}

		#endregion

		#region TakeWhile

		public static IEnumerable<TSource> TakeWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateTakeWhileIterator (source, predicate);
		}

        public static IEnumerable<TSource> TakeWhile<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateTakeWhileIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateTakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			foreach (var element in source) {
				if (!predicate (element))
					yield break;

				yield return element;
			}
		}

		public static IEnumerable<TSource> TakeWhile<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateTakeWhileIterator (source, predicate);
		}

        public static IEnumerable<TSource> TakeWhile<TSource>(this IIterable<TSource> source, Func<TSource, int, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateTakeWhileIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateTakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			int counter = 0;
			foreach (var element in source) {
				if (!predicate (element, counter))
					yield break;

				yield return element;
				counter++;
			}
		}

		#endregion

		#region ThenBy

		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey> (this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return ThenBy<TSource, TKey> (source, keySelector, null);
		}

		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey> (this IOrderedEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Check.SourceAndKeySelector (source, keySelector);

			return source.CreateOrderedEnumerable (keySelector, comparer, false);
		}

		#endregion

		#region ThenByDescending

		public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey> (this IOrderedEnumerable<TSource> source,
			Func<TSource, TKey> keySelector)
		{
			return ThenByDescending<TSource, TKey> (source, keySelector, null);
		}

        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			Check.SourceAndKeySelector (source, keySelector);

			return source.CreateOrderedEnumerable (keySelector, comparer, true);
		}

		#endregion

		#region ToArray

		public static TSource [] ToArray<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			TSource[] array;
			var collection = source as Collections.Generic.ICollection<TSource>;
			if (collection != null) {
				if (collection.Count == 0)
					return EmptyOf<TSource>.Instance();
				
				array = new TSource [collection.Count];
				collection.CopyTo (array, 0);
				return array;
			}

		    var list = new Java.Util.ArrayList<TSource>();
			foreach (var element in source)
			{
			    list.Add(element);
			}
			return list.ToArray<TSource>(new TSource[list.Count]);
		}

        public static TSource[] ToArray<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            TSource[] array;
            var collection = source as Java.Util.ICollection<TSource>;
            if (collection != null)
            {
                if (collection.Size() == 0)
                    return EmptyOf<TSource>.Instance();

                array = new TSource[collection.Size()];
                collection.ToArray(array);
                return array;
            }

            var list = new Java.Util.ArrayList<TSource>();
            foreach (var element in source.AsEnumerable())
            {
                list.Add(element);
            }
            return list.ToArray<TSource>(new TSource[list.Size()]);
        }

        #endregion

		#region ToDictionary
		public static Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return ToDictionary<TSource, TKey, TElement> (source, keySelector, elementSelector, null);
		}

		public static Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Check.SourceAndKeyElementSelectors (source, keySelector, elementSelector);

			if (comparer == null)
				comparer = EqualityComparer<TKey>.Default;

			var dict = new Collections.Generic.Dictionary<TKey, TElement> (comparer);
			foreach (var e in source)
				dict.Add (keySelector (e), elementSelector (e));

			return dict;
		}

		public static Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector)
		{
			return ToDictionary (source, keySelector, null);
		}

		public static Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey> (this IEnumerable<TSource> source,
				Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return ToDictionary<TSource, TKey, TSource> (source, keySelector, Function<TSource>.Identity, comparer);
		}

		#endregion

		#region ToList
		public static List<TSource> ToList<TSource> (this IEnumerable<TSource> source)
		{
			Check.Source (source);

			return new List<TSource> (source);
		}
        public static List<TSource> ToList<TSource>(this IIterable<TSource> source)
        {
            Check.Source(source);

            return new List<TSource>(source);
        }
        #endregion

		#region ToLookup

		public static ILookup<TKey, TSource> ToLookup<TSource, TKey> (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return ToLookup<TSource, TKey, TSource> (source, keySelector, Function<TSource>.Identity, null);
		}

        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IIterable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return ToLookup<TSource, TKey, TSource>(source.AsEnumerable(), keySelector, Function<TSource>.Identity, null);
        }

        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return ToLookup<TSource, TKey, TSource> (source, keySelector, element => element, comparer);
		}

        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return ToLookup<TSource, TKey, TSource>(source.AsEnumerable(), keySelector, element => element, comparer);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return ToLookup<TSource, TKey, TElement> (source, keySelector, elementSelector, null);
		}

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IIterable<TSource> source,
            Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return ToLookup<TSource, TKey, TElement>(source.AsEnumerable(), keySelector, elementSelector, null);
        }

        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source,
			Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Check.SourceAndKeyElementSelectors (source, keySelector, elementSelector);

			List<TElement> nullKeyElements = null;
			
			var dictionary = new Collections.Generic.Dictionary<TKey, List<TElement>> (comparer ?? EqualityComparer<TKey>.Default);
			foreach (var element in source) {
				var key = keySelector (element);

				List<TElement> list;
				
				if (key == null) {
					if (nullKeyElements == null)
						nullKeyElements = new List<TElement> ();
					
					list = nullKeyElements;
				} else if (!dictionary.TryGetValue (key, out list)) {
					list = new List<TElement> ();
					dictionary.Add (key, list);
				}

				list.Add (elementSelector (element));
			}

			return new Lookup<TKey, TElement> (dictionary, nullKeyElements);
		}

	    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IIterable<TSource> source,
	                                                                            Func<TSource, TKey> keySelector,
	                                                                            Func<TSource, TElement> elementSelector,
	                                                                            IEqualityComparer<TKey> comparer)
	    {
	        Check.SourceAndKeyElementSelectors(source, keySelector, elementSelector);
	        return ToLookup(source.AsEnumerable(), keySelector, elementSelector, comparer);
	    }

	    #endregion

		#region SequenceEqual

		public static bool SequenceEqual<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			return first.SequenceEqual (second, null);
		}

		public static bool SequenceEqual<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			Check.FirstAndSecond (first, second);

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			using (IEnumerator<TSource> first_enumerator = first.GetEnumerator (),
				second_enumerator = second.GetEnumerator ()) {

				while (first_enumerator.MoveNext ()) {
					if (!second_enumerator.MoveNext ())
						return false;

					if (!comparer.Equals (first_enumerator.Current, second_enumerator.Current))
						return false;
				}

				return !second_enumerator.MoveNext ();
			}
		}

		#endregion

		#region Union

		public static IEnumerable<TSource> Union<TSource> (this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			Check.FirstAndSecond (first, second);

			return first.Union (second, null);
		}

        public static IEnumerable<TSource> Union<TSource>(this IIterable<TSource> first, IIterable<TSource> second)
        {
            Check.FirstAndSecond(first, second);

            return first.Union(second, null);
        }

        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            Check.FirstAndSecond(first, second);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateUnionIterator(first, second, comparer);
        }

        public static IEnumerable<TSource> Union<TSource>(this IIterable<TSource> first, IIterable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            Check.FirstAndSecond(first, second);

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            return CreateUnionIterator(first.AsEnumerable(), second.AsEnumerable(), comparer);
        }

        static IEnumerable<TSource> CreateUnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			var items = new Collections.Generic.HashSet<TSource> (comparer);
			foreach (var element in first) {
				if (! items.Contains (element)) {
					items.Add (element);
					yield return element;
				}
			}

			foreach (var element in second) {
				if (! items.Contains (element)) {
					items.Add (element);
					yield return element;
				}
			}
		}

		#endregion
		
#if NET_4_0 || MOONLIGHT || MOBILE
		#region Zip
		
		public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult> (this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			Check.FirstAndSecond (first, second);
			if (resultSelector == null)
				throw new ArgumentNullException ("resultSelector");
				
			return CreateZipIterator (first, second, resultSelector);
		}
		
		static IEnumerable<TResult> CreateZipIterator<TFirst, TSecond, TResult> (IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> selector)
		{
			using (IEnumerator<TFirst> first_enumerator = first.GetEnumerator ()) {
				using (IEnumerator<TSecond> second_enumerator = second.GetEnumerator ()) {

					while (first_enumerator.MoveNext () && second_enumerator.MoveNext ()) {
						yield return selector (first_enumerator.Current, second_enumerator.Current);
					}
				}
			}
		}
		
		#endregion
#endif		

		#region Where

		public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateWhereIterator (source, predicate);
		}

        public static IEnumerable<TSource> Where<TSource>(this IIterable<TSource> source, Func<TSource, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateWhereIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateWhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			foreach (TSource element in source)
				if (predicate (element))
					yield return element;
		}

		public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			Check.SourceAndPredicate (source, predicate);

			return CreateWhereIterator (source, predicate);
		}

        public static IEnumerable<TSource> Where<TSource>(this IIterable<TSource> source, Func<TSource, int, bool> predicate)
        {
            Check.SourceAndPredicate(source, predicate);

            return CreateWhereIterator(source.AsEnumerable(), predicate);
        }

        static IEnumerable<TSource> CreateWhereIterator<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			int counter = 0;
			foreach (TSource element in source) {
				if (predicate (element, counter))
					yield return element;
				counter++;
			}
		}

		#endregion

		internal static ReadOnlyCollection<TSource> ToReadOnlyCollection<TSource> (this IEnumerable<TSource> source)
		{
			if (source == null)
				return ReadOnlyCollectionOf<TSource>.Empty();

			var ro = source as ReadOnlyCollection<TSource>;
			if (ro != null)
				return ro;

			return new ReadOnlyCollection<TSource> (source.ToArray<TSource> ());
		}
	}
}

