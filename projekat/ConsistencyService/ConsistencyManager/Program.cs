using ConsistencyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsistencyManager
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
            ServiceReference1.SubscriberClient subscriberClient = new ServiceReference1.SubscriberClient();
            while (!cts.IsCancellationRequested)
            {
                for (int id = 1; id < 10; id++)
                {
                    TemperatureInfo t = subscriberClient.querySensor(id);
                    Console.WriteLine($"Sensor query result: sensor{id} {t.temperature}");
                }
                await Task.Delay(10000);
            }
        }
    }
}
