using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D2
{
    internal class Consumer
    {
        public int Index { get; set; }
        public Consumer() { }
        public Consumer(int index) { Index = index; }

        public void ReceiveMessage()
        {
            Thread.Sleep(1000 * this.Index);
            Console.WriteLine($"Consumer {this.Index} received message!");
            Program.semaphore.Release();
        }
    }
}
