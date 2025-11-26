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
        static TemperatureInfo findBest(List<TemperatureInfo> list)
        {
            int bestIndex = -1;
            double sum = 0;
            foreach (TemperatureInfo t in list)
            {
                sum += t.temperature;
            }
            double avg = sum / list.Count;


            foreach(TemperatureInfo t in list)
            {
                double deviation = Math.Abs(avg - t.temperature);
                if (deviation <= 5) {
                    if (bestIndex == -1)
                    {
                        bestIndex = t.sensor_id-1;
                    }
                    else
                    {
                        if (t.timestamp > list[bestIndex].timestamp)
                        {
                            bestIndex = t.sensor_id - 1;
                        }
                    }
                }
            }

            if (bestIndex == -1)
            {
                DateTime bestTime = list[0].timestamp;
                bestIndex = 0;
                foreach(TemperatureInfo t in list)
                {
                    if (t.timestamp > bestTime)
                    {
                        bestTime = t.timestamp;
                        bestIndex = t.sensor_id-1;
                    }
                } 
            }
            return list[bestIndex];
        }
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
            ServiceReference1.PublisherClient publisherClient = new ServiceReference1.PublisherClient();
            List<TemperatureInfo> temps = new List<TemperatureInfo>();
            double avg = 0;
            for (int i = 1; i <= 10; i++)
            {
                temps.Add(new TemperatureInfo());
            }

            while (!cts.IsCancellationRequested)
            {
                await Task.Delay(60000);

                for (int id = 1; id <= 10; id++)
                {
                    TemperatureInfo t = subscriberClient.querySensor(id);
                    avg += t.temperature;
                    temps[id-1] = t;
                }
                avg = avg / temps.Count;
                TemperatureInfo best = findBest(temps);
                foreach (TemperatureInfo t in temps)
                {
                    Console.WriteLine($"{t.sensor_id}: {t.temperature}, {t.timestamp}");
                }
                Console.WriteLine();
                Console.WriteLine($"BEST: {best.sensor_id}: {best.temperature}, AVG: {avg}");
                Console.WriteLine();
                best.source = "CONSISTENCY_MANAGER";
                best.timestamp = DateTime.Now;
                for (int id = 1; id <= 10; id++)
                {
                    best.sensor_id = id;
                    publisherClient.publishTemp(best);
                }
            }
        }
    }
}
