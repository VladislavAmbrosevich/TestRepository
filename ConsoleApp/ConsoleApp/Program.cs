using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();

            var result = WebClientAsync.AwaitWebClient(new Uri("uri"), cts.Token);
        }
    }
}