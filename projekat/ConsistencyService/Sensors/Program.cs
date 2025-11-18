using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancelToken = cts.Token;

            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Cancelling");
                e.Cancel = true;
                cts.Cancel();
            };

            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                Sensor s = new Sensor(i+1);
                Task t = Task.Run(async () => await s.Run(cancelToken));
                tasks.Add(t);
            }
            await Task.WhenAll(tasks);

        }
    }
}
