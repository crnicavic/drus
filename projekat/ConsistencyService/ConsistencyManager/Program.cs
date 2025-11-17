using ConsistencyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsistencyManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Doing something");
            }
        }
    }
}
