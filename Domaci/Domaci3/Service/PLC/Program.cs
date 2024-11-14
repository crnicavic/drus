using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PLC
{
    internal class Program
    {


        static void Main(string[] args)
        {
            const int sleepTimeMilli = 1500;
            ServiceReference1.PublisherClient publisherClient = new ServiceReference1.PublisherClient();
            while (true)
            {
                publisherClient.Publish();
                Thread.Sleep(sleepTimeMilli);
            }
        }
    }
}
