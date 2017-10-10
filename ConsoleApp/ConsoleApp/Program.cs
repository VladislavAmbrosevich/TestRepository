using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starts");
            Do(Print);
//            Print();
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
    }
}