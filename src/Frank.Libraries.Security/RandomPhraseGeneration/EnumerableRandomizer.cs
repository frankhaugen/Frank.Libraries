using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Frank.Libraries.Security.RandomPhraseGeneration
{
    public class EnumerableRandomizer<T>
    {
        private readonly IReadOnlyList<T> _readOnlyList;

        public EnumerableRandomizer(IEnumerable<T> enumerable) => _readOnlyList = enumerable.ToList();

        private int GetRandomIndex => RandomNumberGenerator.GetInt32(0, _readOnlyList.Count);

        public T GetRandomValue() => _readOnlyList.ElementAt(GetRandomIndex);

        public IEnumerable<T> Shuffle()
        {
            var source = _readOnlyList.ToList();
            var n = source.Count;
            var shuffled = new List<T>(n);
            shuffled.AddRange(source);
            while (n > 1)
            {
                n--;
                var k = RandomNumberGenerator.GetInt32(n + 1);
                (shuffled[k], shuffled[n]) = (shuffled[n], shuffled[k]);
            }

            return shuffled;
        }
    }
}