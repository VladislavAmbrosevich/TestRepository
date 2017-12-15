using System;

namespace MyLinq
{
    public static class EnumerableExtensions
    {
        public static IEnumerableOfT<T> Where<T>(this IEnumerableOfT<T> source, Func<T, bool> predicate)
        {
            var iterator = source.GetEnumerator();
        }

        public static MyList<T> ToMyList<T>(this IEnumerableOfT<T> source)
        {
            
        }
    }
}