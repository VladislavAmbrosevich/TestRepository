using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starts");
//            Do(Print);
//            Print();
            TestLinq();
            Console.ReadLine();

        }

        private static void Do(Action action)
        {
            var cts = new CancellationTokenSource();
            Task.Run(() =>
            {
                var result = WebClientAsync.AwaitWebClient(new Uri("http://tut.by"), cts.Token);
                Console.WriteLine(result.Result);
            }).ContinueWith(t => action());
        }

        private static void Print()
        {
            Console.WriteLine("Finished");
        }

        private static void TestLinq()
        {
            var list = new List<int>{1,3,5,7,9};
            var query = list.Where(x => x > 3);
            var newList = query.ToList();
            Console.WriteLine(newList[0]);
        }
    }
}