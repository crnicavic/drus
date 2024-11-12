using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D2
{
    internal class Program
    {
        public static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount:N,maxCount:N);
        public const int N = 5;

        static void Main(string[] args)
        {
            //for(int i = 1; i <= 10; ++i)
            //{
            //    Thread t = new Thread(DoSomeWork)
            //    {
            //        Name = $"Thread-{i}"
            //    };
            //    t.Start();
            //}    
            Producer producer = new Producer();
            List<Consumer> consumers = new List<Consumer>(N);
            for(int i = 1; i <= 5; i++)
            {
                consumers.Add(new Consumer(i));
            }
            producer.FillTheBuffer(consumers);
        }
        public static void DoSomeWork()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} want to work.....");
            semaphore.Wait();

            Console.WriteLine($"Thread {Thread.CurrentThread.Name} start working.....");
            int num = Int32.Parse(Thread.CurrentThread.Name[Thread.CurrentThread.Name.Length - 1].ToString());
            Thread.Sleep(1000 * num);

            Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished work.....");
            semaphore.Release();
        }
    }
}
