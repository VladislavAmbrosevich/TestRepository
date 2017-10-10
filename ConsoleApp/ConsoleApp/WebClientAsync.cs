using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class WebClientAsync
    {
        public static Task<string> AwaitWebClient(Uri uri, CancellationToken ct)
        {
            return Task.Run(() => { 
                var wc = new System.Net.WebClient();
                var tcs = new TaskCompletionSource<string>();

                wc.DownloadStringCompleted += (s, e) =>
                {
                    if (e.Cancelled)
                    {
                        tcs.SetCanceled();
                    }
                    else if (e.Error != null)
                    {
                        tcs.SetException(e.Error);
                    }
                    else
                    {
                        tcs.SetResult(e.Result);
                    }
                };

                wc.DownloadStringAsync(uri);
                var callback = ct.Register(() =>
                {
                    wc.CancelAsync();
                });
                var result = tcs.Task;

                callback.Dispose();
                return result;
            }, ct);
        }
    }
}