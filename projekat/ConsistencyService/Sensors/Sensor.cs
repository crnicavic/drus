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
                while (!cancelToken.IsCancellationRequested)
                {
                    // ensurance that the delay is at least 1 second
                    int delay = random.Next() % (Sensor.maxTimeDelay - 1) + 1;
                    await Task.Delay(delay * 1000);

                    // range of temperature is 10 - 30;
                    double temperature = random.NextDouble() * 20 + 10;
                    info.temperature = temperature;
                    info.timestamp = DateTime.Now;

                    Console.WriteLine($"Sensor {this.sensorID} measured {temperature}");

                    publisherClient.publishTemp(info);
                }
            }
        }
    }
}
