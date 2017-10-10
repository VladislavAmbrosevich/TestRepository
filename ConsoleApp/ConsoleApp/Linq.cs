using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Linq
    {
        public void Method1()
        {
            var list = new List<int>{1,3,5,7,9};
            var chosen = list.Where(x => x > 3);
            chosen.ToList();
        }

        public IEnumerable<T> Where<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T source1 in source)
            {
                if (predicate(source1))
                    yield return source1;
            }
        }
    }
}
