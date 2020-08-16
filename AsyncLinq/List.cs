using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLinq
{
    // ReSharper disable once UnusedType.Global
    public static class List
    {
        
        /// <inheritdoc cref="System.Linq.Enumerable.Aggregate{TSource,TAccumulate}(System.Collections.Generic.IEnumerable{TSource},TAccumulate,Func{TAccumulate,TSource,TAccumulate})"/>
        public static async Task<TSource> AggregateAsync<TSource>(
            this Task<List<TSource>> source, Func<TSource, TSource, TSource> func,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Aggregate<TSource>(func);
        }
        
        /// <inheritdoc cref="System.Linq.Enumerable.Aggregate{TSource,TAccumulate}(System.Collections.Generic.IEnumerable{TSource},TAccumulate,Func{TAccumulate,TSource,TAccumulate})"/>
        public static async Task<TAccumulate> AggregateAsync<TSource, TAccumulate>(
            this Task<List<TSource>> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Aggregate<TSource, TAccumulate>(seed, func);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Aggregate{TSource,TAccumulate,TResult}(System.Collections.Generic.IEnumerable{TSource},TAccumulate,Func{TAccumulate,TSource,TAccumulate},Func{TAccumulate,TResult})"/>
        public static async Task<TResult> AggregateAsync<TSource, TAccumulate, TResult>(
            this Task<List<TSource>> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func,
            Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Aggregate<TSource, TAccumulate, TResult>(seed, func, resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Any{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<bool> AnyAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Any<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Any{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<bool> AnyAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Any<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.All{TSource}(IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<bool> AllAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).All<TSource>(predicate);
        }

#if NETSTANDARD1_6
        /// <inheritdoc cref="System.Linq.Enumerable.Prepend{TSource}(System.Collections.Generic.IEnumerable{TSource},TSource)"/>
        public static async Task<IEnumerable<TSource>> PrependAsync<TSource>(this Task<List<TSource>> source,
            TSource element, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Prepend<TSource>(element);
        }
#endif

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{int})"/>
        public static async Task<double> AverageAsync(this Task<List<int>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{int?})"/>
        public static async Task<double?> AverageAsync(this Task<List<int?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{long})"/>
        public static async Task<double> AverageAsync(this Task<List<long>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{long?})"/>
        public static async Task<double?> AverageAsync(this Task<List<long?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{float})"/>
        public static async Task<float> AverageAsync(this Task<List<float>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{float?})"/>
        public static async Task<float?> AverageAsync(this Task<List<float?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{double})"/>
        public static async Task<double> AverageAsync(this Task<List<double>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{double?})"/>
        public static async Task<double?> AverageAsync(this Task<List<double?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{decimal})"/>
        public static async Task<decimal> AverageAsync(this Task<List<decimal>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average(System.Collections.Generic.IEnumerable{decimal?})"/>
        public static async Task<decimal?> AverageAsync(this Task<List<decimal?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int})"/>
        public static async Task<double> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int?})"/>
        public static async Task<double?> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long})"/>
        public static async Task<double> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long?})"/>
        public static async Task<double?> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float})"/>
        public static async Task<float> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float?})"/>
        public static async Task<float?> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double})"/>
        public static async Task<double> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double?})"/>
        public static async Task<double?> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal})"/>
        public static async Task<decimal> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Average{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal?})"/>
        public static async Task<decimal?> AverageAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Average<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Contains{TSource}(System.Collections.Generic.IEnumerable{TSource},TSource)"/>
        public static async Task<bool> ContainsAsync<TSource>(this Task<List<TSource>> source, TSource value,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Contains<TSource>(value);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Contains{TSource}(System.Collections.Generic.IEnumerable{TSource},TSource,IEqualityComparer{TSource}?)"/>
        public static async Task<bool> ContainsAsync<TSource>(this Task<List<TSource>> source, TSource value,
            IEqualityComparer<TSource>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Contains<TSource>(value, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Count{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<int> CountAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Count<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Count{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<int> CountAsync<TSource>(this Task<List<TSource>> source,
           CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Count;
        }

        /// <inheritdoc cref="System.Linq.Enumerable.LongCount{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<long> LongCountAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).LongCount<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.LongCount{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<long> LongCountAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).LongCount<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.DefaultIfEmpty{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> DefaultIfEmptyAsync<TSource>(
            this Task<List<TSource>> source, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).DefaultIfEmpty<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.DefaultIfEmpty{TSource}(System.Collections.Generic.IEnumerable{TSource},TSource)"/>
        public static async Task<IEnumerable<TSource>> DefaultIfEmptyAsync<TSource>(
            this Task<List<TSource>> source, TSource defaultValue, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).DefaultIfEmpty<TSource>(defaultValue);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Distinct{TSource}(System.Collections.Generic.IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<IEnumerable<TSource>> DistinctAsync<TSource>(this Task<List<TSource>> source,
            IEqualityComparer<TSource>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Distinct<TSource>(comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Distinct{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> DistinctAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Distinct<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ElementAt{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<TSource> ElementAt<TSource>(this Task<List<TSource>> source,
            int index, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ElementAt<TSource>(index);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ElementAtOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<TSource> ElementAtOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            int index, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ElementAtOrDefault<TSource>(index);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Except{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> ExceptAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Except<TSource>(second);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Except{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<IEnumerable<TSource>> ExceptAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Except<TSource>(second, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.First{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> FirstAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).First<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.First{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> FirstAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).First<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.FirstOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> FirstOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).FirstOrDefault<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.FirstOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> FirstOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).FirstOrDefault<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<IEnumerable<IGrouping<TKey, TSource>>> GroupByAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<IGrouping<TKey, TSource>>> GroupByAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})"/>
        public static async Task<IEnumerable<IGrouping<TKey, TElement>>> GroupByAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<IGrouping<TKey, TElement>>> GroupByAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey,TResult}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey},Func{TKey,IEnumerable{TSource},TResult})"/>
        public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TResult>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TKey, IEnumerable<TSource>, TResult> resultSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TResult>(keySelector, resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource, TKey, TElement,TResult}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey>,Func{TSource,TElement},Func{TKey,IEnumerable{TElement},TResult})"/>
        public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TElement, TResult>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TElement, TResult>(keySelector, elementSelector,
                                                                            resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource,TKey,TResult}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey>,Func{TKey,IEnumerable{TSource},TResult},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TResult>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TResult>(keySelector, resultSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupBy{TSource, TKey, TElement, TResult}(System.Collections.Generic.IEnumerable{TSource>, Func{TSource,TKey},Func{TSource,TElement},Func{TKey,IEnumerable{TElement},TResult},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TElement, TResult>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).GroupBy<TSource, TKey, TElement, TResult>(keySelector, elementSelector,
                                                                            resultSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupJoin{TOuter, TInner, TKey, TResult}(System.Collections.Generic.IEnumerable{TOuter>, IEnumerable{TInner}, Func{TOuter,TKey},Func{TInner,TKey>,Func{TOuter,IEnumerable{TInner},TResult})"/>
        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<List<TOuter>> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (outer == null) throw new ArgumentNullException(nameof(outer));
            return (await outer).GroupJoin<TOuter, TInner, TKey, TResult>(inner, outerKeySelector,
                                                                          innerKeySelector, resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.GroupJoin{TOuter, TInner, TKey, TResult}(System.Collections.Generic.IEnumerable{TOuter>, IEnumerable{TInner}, Func{TOuter,TKey},Func{TInner,TKey>,Func{TOuter,IEnumerable{TInner},TResult},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<List<TOuter>> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (outer == null) throw new ArgumentNullException(nameof(outer));
            return (await outer).GroupJoin<TOuter, TInner, TKey, TResult>(inner, outerKeySelector,
                                                                          innerKeySelector, resultSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Intersect{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> IntersectAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, 
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Intersect<TSource>(second);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Intersect{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<IEnumerable<TSource>> IntersectAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Intersect<TSource>(second, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Join{TOuter, TInner, TKey, TResult}(System.Collections.Generic.IEnumerable{TOuter>, IEnumerable{TInner}, Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,TInner,TResult})"/>
        public static async Task<IEnumerable<TResult>> JoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<List<TOuter>> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector,
             CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (outer == null) throw new ArgumentNullException(nameof(outer));
            return (await outer).Join<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector,
                                                                     resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Join{TOuter, TInner, TKey, TResult}(System.Collections.Generic.IEnumerable{TOuter>, IEnumerable{TInner}, Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,TInner,TResult},IEqualityComparer{TKey}?)"/>
        public static async Task<IEnumerable<TResult>> JoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<List<TOuter>> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector,
            IEqualityComparer<TKey>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (outer == null) throw new ArgumentNullException(nameof(outer));
            return (await outer).Join<TOuter, TInner, TKey, TResult>(inner, outerKeySelector, innerKeySelector,
                                                                     resultSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Last{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> LastAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Last<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Last{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> LastAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Last<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.LastOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> LastOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).LastOrDefault<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.LastOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> LastOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).LastOrDefault<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToLookup{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToLookup<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToLookup{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey}?)"/>
        public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToLookup<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToLookup{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})"/>
        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToLookup<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToLookup{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey}?)"/>
        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToLookup<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{int})"/>
        public static async Task<int> MaxAsync(this Task<List<int>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{int?})"/>
        public static async Task<int?> MaxAsync(this Task<List<int?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{long})"/>
        public static async Task<long> MaxAsync(this Task<List<long>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{long?})"/>
        public static async Task<long?> MaxAsync(this Task<List<long?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{double})"/>
        public static async Task<double> MaxAsync(this Task<List<double>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{double?})"/>
        public static async Task<double?> MaxAsync(this Task<List<double?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{float})"/>
        public static async Task<float> MaxAsync(this Task<List<float>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{float?})"/>
        public static async Task<float?> MaxAsync(this Task<List<float?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{decimal})"/>
        public static async Task<decimal> MaxAsync(this Task<List<decimal>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max(System.Collections.Generic.IEnumerable{decimal?})"/>
        public static async Task<decimal?> MaxAsync(this Task<List<decimal?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> MaxAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int})"/>
        public static async Task<int> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int?})"/>
        public static async Task<int?> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long})"/>
        public static async Task<long> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long?})"/>
        public static async Task<long?> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float})"/>
        public static async Task<float> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float?})"/>
        public static async Task<float?> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double})"/>
        public static async Task<double> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double?})"/>
        public static async Task<double?> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal})"/>
        public static async Task<decimal> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal?})"/>
        public static async Task<decimal?> MaxAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Max{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TResult})"/>
        public static async Task<TResult> MaxAsync<TSource, TResult>(this Task<List<TSource>> source,
            Func<TSource, TResult> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Max<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{int})"/>
        public static async Task<int> MinAsync(this Task<List<int>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{int?})"/>
        public static async Task<int?> MinAsync(this Task<List<int?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{long})"/>
        public static async Task<long> MinAsync(this Task<List<long>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{long?})"/>
        public static async Task<long?> MinAsync(this Task<List<long?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{float})"/>
        public static async Task<float> MinAsync(this Task<List<float>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{float?})"/>
        public static async Task<float?> MinAsync(this Task<List<float?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{double})"/>
        public static async Task<double> MinAsync(this Task<List<double>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{double?})"/>
        public static async Task<double?> MinAsync(this Task<List<double?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{decimal})"/>
        public static async Task<decimal> MinAsync(this Task<List<decimal>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min(System.Collections.Generic.IEnumerable{decimal?})"/>
        public static async Task<decimal?> MinAsync(this Task<List<decimal?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> MinAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int})"/>
        public static async Task<int> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int?})"/>
        public static async Task<int?> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long})"/>
        public static async Task<long> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long?})"/>
        public static async Task<long?> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float})"/>
        public static async Task<float> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float?})"/>
        public static async Task<float?> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double})"/>
        public static async Task<double> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double?})"/>
        public static async Task<double?> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal})"/>
        public static async Task<decimal> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal?})"/>
        public static async Task<decimal?> MinAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Min{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TResult})"/>
        public static async Task<TResult> MinAsync<TSource, TResult>(this Task<List<TSource>> source,
            Func<TSource, TResult> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Min<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.OrderBy{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<IOrderedEnumerable<TSource>> OrderByAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, 
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).OrderBy<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.OrderBy{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey}?)"/>
        public static async Task<IOrderedEnumerable<TSource>> OrderByAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).OrderBy<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.OrderByDescending{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<IOrderedEnumerable<TSource>> OrderByDescendingAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).OrderByDescending<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.OrderByDescending{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey}?)"/>
        public static async Task<IOrderedEnumerable<TSource>> OrderByDescendingAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).OrderByDescending<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Select{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TResult})"/>
        public static async Task<IEnumerable<TResult>> SelectAsync<TSource, TResult>(
            this Task<List<TSource>> source, Func<TSource, TResult> selector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Select<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Select{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,TResult})"/>
        public static async Task<IEnumerable<TResult>> SelectAsync<TSource, TResult>(
            this Task<List<TSource>> source, Func<TSource, int, TResult> selector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Select<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SelectMany{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,IEnumerable{TResult}})"/>
        public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TResult>(
            this Task<List<TSource>> source, Func<TSource, IEnumerable<TResult>> selector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SelectMany<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SelectMany{TSource,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,IEnumerable{TResult}})"/>
        public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TResult>(
            this Task<List<TSource>> source, Func<TSource, int, IEnumerable<TResult>> selector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SelectMany<TSource, TResult>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SelectMany{TSource,TCollection,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,IEnumerable{TCollection}>,Func{TSource,TCollection,TResult})"/>
        public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TCollection, TResult>(
            this Task<List<TSource>> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
            Func<TSource, TCollection, TResult> resultSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SelectMany<TSource, TCollection, TResult>(collectionSelector, resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SelectMany{TSource,TCollection,TResult}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,IEnumerable{TCollection}>,Func{TSource,TCollection,TResult})"/>
        public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TCollection, TResult>(
            this Task<List<TSource>> source, Func<TSource, IEnumerable<TCollection>> collectionSelector,
            Func<TSource, TCollection, TResult> resultSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SelectMany<TSource, TCollection, TResult>(collectionSelector, resultSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SequenceEqual{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource})"/>
        public static async Task<bool> SequenceEqualAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, 
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).SequenceEqual<TSource>(second);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SequenceEqual{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<bool> SequenceEqualAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).SequenceEqual<TSource>(second, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Single{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> SingleAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Single<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Single{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> SingleAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Single<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SingleOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource> SingleOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SingleOrDefault<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SingleOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<TSource> SingleOrDefaultAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SingleOrDefault<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SkipWhile{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<IEnumerable<TSource>> SkipWhileAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SkipWhile<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.SkipWhile{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,bool})"/>
        public static async Task<IEnumerable<TSource>> SkipWhileAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SkipWhile<TSource>(predicate);
        }

#if NETSTANDARD2_1
        /// <inheritdoc cref="System.Linq.Enumerable.SkipLast{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<IEnumerable<TSource>> SkipLastAsync<TSource>(this Task<List<TSource>> source,
            int count, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).SkipLast<TSource>(count);
        }
#endif
        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{int})"/>
        public static async Task<int> SumAsync(this Task<List<int>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{int?})"/>
        public static async Task<int?> SumAsync(this Task<List<int?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{long})"/>
        public static async Task<long> SumAsync(this Task<List<long>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{long?})"/>
        public static async Task<long?> SumAsync(this Task<List<long?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{float})"/>
        public static async Task<float> SumAsync(this Task<List<float>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{float?})"/>
        public static async Task<float?> SumAsync(this Task<List<float?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{double})"/>
        public static async Task<double> SumAsync(this Task<List<double>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{double?})"/>
        public static async Task<double?> SumAsync(this Task<List<double?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{decimal})"/>
        public static async Task<decimal> SumAsync(this Task<List<decimal>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable{decimal?})"/>
        public static async Task<decimal?> SumAsync(this Task<List<decimal?>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int})"/>
        public static async Task<int> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int?})"/>
        public static async Task<int?> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long})"/>
        public static async Task<long> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,long?})"/>
        public static async Task<long?> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, long?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float})"/>
        public static async Task<float> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,float?})"/>
        public static async Task<float?> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, float?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double})"/>
        public static async Task<double> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,double?})"/>
        public static async Task<double?> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, double?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal})"/>
        public static async Task<decimal> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Sum{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,decimal?})"/>
        public static async Task<decimal?> SumAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, decimal?> selector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Sum<TSource>(selector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.TakeWhile{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<IEnumerable<TSource>> TakeWhileAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).TakeWhile<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.TakeWhile{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,bool})"/>
        public static async Task<IEnumerable<TSource>> TakeWhileAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).TakeWhile<TSource>(predicate);
        }

#if NETSTANDARD2_1
        /// <inheritdoc cref="System.Linq.Enumerable.TakeLast{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<IEnumerable<TSource>> TakeLastAsync<TSource>(this Task<List<TSource>> source,
            int count, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).TakeLast<TSource>(count);
        }
#endif

        /// <inheritdoc cref="System.Linq.Enumerable.ToList{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<List<TSource>> ToListAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToList<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToDictionary{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToDictionary<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToDictionary{TSource,TKey}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey}?)"/>
        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToDictionary<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToDictionary{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})"/>
        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToDictionary{TSource,TKey,TElement}(System.Collections.Generic.IEnumerable{TSource>,Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey}?)"/>
        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this Task<List<TSource>> source, Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector, IEqualityComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector, comparer);
        }

#if NETSTANDARD2_1
        /// <inheritdoc cref="System.Linq.Enumerable.ToHashSet{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<HashSet<TSource>> ToHashSetAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToHashSet<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToHashSet{TSource}(System.Collections.Generic.IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<HashSet<TSource>> ToHashSetAsync<TSource>(this Task<List<TSource>> source,
            IEqualityComparer<TSource>? comparer, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToHashSet<TSource>(comparer);
        }
#endif

        /// <inheritdoc cref="System.Linq.Enumerable.Union{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> UnionAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, 
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Union<TSource>(second);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Union{TSource}(System.Collections.Generic.IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)"/>
        public static async Task<IEnumerable<TSource>> UnionAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Union<TSource>(second, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Where{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,bool})"/>
        public static async Task<IEnumerable<TSource>> WhereAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Where<TSource>(predicate);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Where{TSource}(System.Collections.Generic.IEnumerable{TSource},Func{TSource,int,bool})"/>
        public static async Task<IEnumerable<TSource>> WhereAsync<TSource>(this Task<List<TSource>> source,
            Func<TSource, int, bool> predicate, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Where<TSource>(predicate);
        }
        
#if NETSTANDARD1_6
        /// <inheritdoc cref="System.Linq.Enumerable.Append{TSource}(System.Collections.Generic.IEnumerable{TSource},TSource)"/>
        public static async Task<IEnumerable<TSource>> AppendAsync<TSource>(this Task<List<TSource>> source,
            TSource element, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Append<TSource>(element);
        }
#endif

        /// <inheritdoc cref="System.Linq.Enumerable.AsEnumerable{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
            this Task<List<TSource>> source, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).AsEnumerable<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Concat{TSource}(System.Collections.Generic.IEnumerable{TSource},System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> ConcatAsync<TSource>(this Task<List<TSource>> first,
            IEnumerable<TSource> second, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (first == null) throw new ArgumentNullException(nameof(first));
            return (await first).Concat<TSource>(second);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Reverse{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<IEnumerable<TSource>> ReverseAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Reverse<TSource>();
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Skip{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<IEnumerable<TSource>> SkipAsync<TSource>(this Task<List<TSource>> source,
            int count, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Skip<TSource>(count);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.Take{TSource}(System.Collections.Generic.IEnumerable{TSource},int)"/>
        public static async Task<IEnumerable<TSource>> TakeAsync<TSource>(this Task<List<TSource>> source,
            int count, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).Take<TSource>(count);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ToArray{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
        public static async Task<TSource[]> ToArrayAsync<TSource>(this Task<List<TSource>> source,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ToArray<TSource>();
        }
 
    }
}