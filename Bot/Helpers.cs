using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    public static class Helpers
    {
        public static Tuple<TKey, TValue> MinBy<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector) where TKey: IComparable
        {
            return source.Aggregate((Tuple<TKey, TValue>)null, (min, value) =>
            {
                var key = keySelector(value);

                return min == null || min.Item1.CompareTo(key) > 0 ? Tuple.Create(key, value) : min;
            });
        }
    }
}
