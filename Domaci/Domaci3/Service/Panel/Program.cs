using Panel.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Panel
{

    public class Callback : ServiceReference1.ISubscriberCallback
    {
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static List<int> data = new List<int>();
        const int GRAPH_OFFSET = 4;
        void ISubscriberCallback.onNotify(string variable, string address, double value)
        {
            int h = Console.WindowHeight;
            int w = Console.WindowWidth;
            // inicijalizujem ga ovde da bi se ocuvala vrednost
            int i = 0;
            int j = h;
            data.Add((int)value);
            while (data.Count > w-GRAPH_OFFSET)
            {
                data.RemoveAt(0);
            }
            Console.Clear();
            for (; i < data.Count; ++i)
            {
                int row = data[i] * h / 100;
                j = h;
                for (; j >= h-row; --j)
                {
                    WriteAt("|", i+GRAPH_OFFSET, j);
                }

            }
            WriteAt($"100", 0, 0);
            WriteAt($"0", 0, h-1);
            WriteAt($"{data.Last<int>().ToString()}", 0, j+1);
        }
    }
    internal class Program
    {
        static ServiceReference1.SubscriberClient subscriberClient;

        static void Main(string[] args)
        {
            Console.WriteLine("Uneti promenljivu koju zelite da panel prati");
            string variable = Console.ReadLine();

            InstanceContext ic = new InstanceContext(new Callback());
            subscriberClient = new ServiceReference1.SubscriberClient(ic);

            subscriberClient.initHMI(variable);
            Console.ReadLine();
        }
    }
}
