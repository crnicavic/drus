using Sensors.ServiceReference1;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Sensor
    {
        public int sensorID;
        private static Random _random = new Random();
        const int maxTimeDelay = 10;
        private Random random;
        private ServiceReference1.PublisherClient publisherClient;
        private static readonly object _randomLock = new object();

        public Sensor(int id) {
            this.sensorID = id;
            this.random = Sensor._random;
            this.publisherClient = new ServiceReference1.PublisherClient();
        }

        public async Task Run(CancellationToken cancelToken)
        {
            {
                TemperatureInfo info = new TemperatureInfo();
                info.sensor_id = this.sensorID;
                info.source = "SENSOR";
                double temperature = 0;
                int delay = 0;
                while (!cancelToken.IsCancellationRequested)
                {

                    lock (_randomLock)
                    {
                        // ensurance that the delay is at least 1 second
                        delay = random.Next() % (Sensor.maxTimeDelay - 1) + 1;
                        temperature = random.NextDouble() * 20 + 10;
                    }
                    await Task.Delay(delay * 1000);

                    info.temperature = temperature;
                    info.timestamp = DateTime.Now;

                    Console.WriteLine($"Sensor {this.sensorID} measured {temperature}");

                    publisherClient.publishTemp(info);
                }
            }
        }
    }
}
