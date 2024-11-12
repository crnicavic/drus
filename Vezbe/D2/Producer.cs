using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    internal class Producer
    {
        private int _messageId = 1;
        public Producer() { }
        public void FillTheBuffer(List<Consumer> consumers)
        {
            while (true)
            {
                if(Program.semaphore.CurrentCount == Program.N)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Sending message {_messageId++}............");
                    Parallel.ForEach(consumers, consumer =>
                    {
                        Program.semaphore.Wait();
                        consumer.ReceiveMessage();
                    });
                }
            }
        }
    }
}
