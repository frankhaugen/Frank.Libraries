namespace Frank.Libraries.CodeGeneration.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<string> ToStrings<T>(this IEnumerable<T> source)
    {
        var output = new List<string>();

        foreach (var value in source)
        {
            output.TryAdd(value!.ToString());
        }

        return output;
    }

    public static IEnumerable<T> DoForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        if (source == null || !source.Any())
        {
            return source;
        }

        foreach (var value in source)
        {
            if (value == null)
            {
                continue;
            }

            action.Invoke(value);
        }

        return source;
    }

    /// <summary>Returns distinct elements from a sequence according to a specified key selector function.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
    /// <typeparam name="TKey">The type of key to distinguish elements by.</typeparam>
    /// <param name="source">The sequence to remove duplicate elements from.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> that contains distinct elements from the source sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <remarks>
    ///     <para>
    ///         This method is implemented by using deferred execution. The immediate return value is an object that stores
    ///         all the information that is required to perform the action. The query represented by this method is not
    ///         executed until the object is enumerated either by calling its `GetEnumerator` method directly or by using
    ///         `foreach` in Visual C# or `For Each` in Visual Basic.
    ///     </para>
    ///     <para>
    ///         The <see cref="DistinctBy{TSource, TKey}(IEnumerable{TSource}, Func{TSource, TKey})" /> method returns an
    ///         unordered sequence that contains no duplicate values. The default equality comparer,
    ///         <see cref="EqualityComparer{T}.Default" />, is used to compare values.
    ///     </para>
    /// </remarks>
    public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) => Distinct(source, keySelector, null);

    /// <summary>Returns distinct elements from a sequence according to a specified key selector function.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
    /// <typeparam name="TKey">The type of key to distinguish elements by.</typeparam>
    /// <param name="source">The sequence to remove duplicate elements from.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <param name="comparer">An <see cref="IEqualityComparer{TKey}" /> to compare keys.</param>
    /// <returns>An <see cref="IEnumerable{T}" /> that contains distinct elements from the source sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <remarks>
    ///     <para>
    ///         This method is implemented by using deferred execution. The immediate return value is an object that stores
    ///         all the information that is required to perform the action. The query represented by this method is not
    ///         executed until the object is enumerated either by calling its `GetEnumerator` method directly or by using
    ///         `foreach` in Visual C# or `For Each` in Visual Basic.
    ///     </para>
    ///     <para>
    ///         The
    ///         <see cref="DistinctBy{TSource, TKey}(IEnumerable{TSource}, Func{TSource, TKey}, IEqualityComparer{TKey}?)" />
    ///         method returns an unordered sequence that contains no duplicate values. If <paramref name="comparer" /> is
    ///         <see langword="null" />, the default equality comparer, <see cref="EqualityComparer{T}.Default" />, is used to
    ///         compare values.
    ///     </para>
    /// </remarks>
    public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer) => DistinctByIterator(source, keySelector, comparer);

    private static IEnumerable<TSource> DistinctByIterator<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey>? comparer)
    {
        using var enumerator = source.GetEnumerator();

        if (enumerator.MoveNext())
        {
            var set = new HashSet<TKey>(comparer);
            do
            {
                var element = enumerator.Current;
                if (set.Add(keySelector(element)))
                {
                    yield return element;
                }
            } while (enumerator.MoveNext());
        }
    }
}