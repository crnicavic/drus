using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domaci2
{
    
    internal class Toilet
    {
        public static SemaphoreSlim toilet = new SemaphoreSlim(1);
        public static SemaphoreSlim[] entryMutex = { new SemaphoreSlim(1), new SemaphoreSlim(1), };
        public static SemaphoreSlim seats = new SemaphoreSlim(Program.TOILET_CAPACITY);
        public static SemaphoreSlim messageMutex = new SemaphoreSlim(1);
        public static SemaphoreSlim genderSwitch = new SemaphoreSlim(Program.M);
        public static int[] cnt = { 0, 0 };

        public static void print(string msg)
        {
            messageMutex.Wait();
            Console.WriteLine(msg);
            messageMutex.Release();
        }

        public static void SimulateToilet(List<Person> people)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(people, person =>
            {
                genderSwitch.Wait();
                entryMutex[(int)person.gender].Wait();
                if (++cnt[(int)person.gender] == 1)
                {
                    toilet.Wait();
                    print($"{person.gender}S occupied the bathroom");
                }
                entryMutex[(int)person.gender].Release();

                genderSwitch.Release();

                seats.Wait();
                print($"{person.gender} {person.id} started using the toilet, Seats free: {seats.CurrentCount}");
                Thread.Sleep(10000);
                seats.Release();
                print($"{person.gender} {person.id} finished using the toilet, Seats free: {seats.CurrentCount}");

                entryMutex[(int)person.gender].Wait();
                if (--cnt[(int)person.gender] == 0)
                {
                    print($"{person.gender}S have left he bathroom");
                    toilet.Release();
                }
                entryMutex[(int)person.gender].Release();
            });
            stopwatch.Stop();
            print($"Execution time: {(float)stopwatch.ElapsedMilliseconds / 1000}");
        }

    }
}
