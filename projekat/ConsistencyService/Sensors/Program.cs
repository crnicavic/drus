using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                Sensor s = new Sensor(i+1);
                Task t = Task.Run(async () => await s.Run());
                tasks.Add(t);
                break;
            }
            await Task.WhenAll(tasks);
        }
    }
}
