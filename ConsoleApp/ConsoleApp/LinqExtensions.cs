using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var linq = new Linq();

            return linq.Where(source, predicate);
        }

        public static List<T> ToList<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return new List<T>(source);
        }
    }
}
