using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLinq
{
    public static partial class Enumerable
    {
        
        /// <inheritdoc cref="System.Linq.Enumerable.ThenBy{TSource,TKey}(System.Linq.IOrderedEnumerable{TSource},Func{TResult})"/>
        public static async Task<IOrderedEnumerable<TSource>> ThenByAsync<TSource, TKey>(
            this Task<IOrderedEnumerable<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ThenBy<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ThenBy{TSource,TKey}(System.Linq.IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey}?)"/>
        public static async Task<IOrderedEnumerable<TSource>> ThenByAsync<TSource, TKey>(
            this Task<IOrderedEnumerable<TSource>> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ThenBy<TSource, TKey>(keySelector, comparer);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ThenByDescending{TSource,TKey}(System.Linq.IOrderedEnumerable{TSource},Func{TSource,TKey})"/>
        public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
            this Task<IOrderedEnumerable<TSource>> source, Func<TSource, TKey> keySelector,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ThenByDescending<TSource, TKey>(keySelector);
        }

        /// <inheritdoc cref="System.Linq.Enumerable.ThenByDescending{TSource,TKey}(System.Linq.IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey}?)"/>
        public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
            this Task<IOrderedEnumerable<TSource>> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (source == null) throw new ArgumentNullException(nameof(source));
            return (await source).ThenByDescending<TSource, TKey>(keySelector, comparer);
        }
    }
}