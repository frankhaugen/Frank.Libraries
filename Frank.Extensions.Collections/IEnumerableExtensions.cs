using System;
using System.Collections.Generic;
using System.Linq;

namespace Frank.Extensions.Collections
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> items, int maxItems = 256)
        {
            return items.Select((item, inx) => new { item, inx })
                .GroupBy(x => x.inx / maxItems)
                .Select(g => g.Select(x => x.item));
        }

        public static T Random<T>(this IEnumerable<T> items)
        {
            var random = new Random();
            var count = items.Count();

            var index = random.Next(0, count);

            return items.ElementAt(index);
        }
    }
}
