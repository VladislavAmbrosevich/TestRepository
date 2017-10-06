using System;
using System.Threading;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starts");
            Do();
            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        private static async void Do()
        {
            var cts = new CancellationTokenSource();
            var result = await WebClientAsync.AwaitWebClient(new Uri("http://tut.by"), cts.Token);
            Console.WriteLine(result);
        }
    }
}