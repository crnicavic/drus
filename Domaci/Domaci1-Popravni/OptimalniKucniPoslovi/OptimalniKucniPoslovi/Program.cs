using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OptimalniKucniPoslovi
{
    internal class Program
    {
        const int WASHING_MASHINE_MS = 90000;
        const int DISH_WASHER_MS= 60000;
        const int SHOPPING_MS = 15000;
        const int PREPARE_ONION_MS = 3000;
        const int PREPARE_POTATO_MS = 5000;
        const int PREPARE_MEAT_MS = 7000;
        const int COOKING_MS = 45000;
        static Stopwatch sw = new Stopwatch();

        static async Task WashLaundry()
        {
            Console.WriteLine($"Started washing mashine... \t\t({sw.ElapsedMilliseconds}ms)");
            await Task.Delay(WASHING_MASHINE_MS);
            Console.WriteLine($"Washing mashine finished \t\t({sw.ElapsedMilliseconds}ms)");

            return;
        }

        static async Task WashDishes()
        {
            Console.WriteLine($"Started dish washer... \t\t\t({sw.ElapsedMilliseconds}ms)");
            await Task.Delay(DISH_WASHER_MS);
            Console.WriteLine($"Dish washer finished \t\t\t({sw.ElapsedMilliseconds}ms)");

            return;
        }

        static void GoShopping()
        {
            Console.WriteLine($"Went out for shopping... \t\t({sw.ElapsedMilliseconds}ms)");
            Thread.Sleep(SHOPPING_MS);
            Console.WriteLine($"Came back from shopping \t\t({sw.ElapsedMilliseconds}ms)");
        }

        static void PrepareOnions()
        {
            Console.WriteLine($"Started onion preparation... \t\t({sw.ElapsedMilliseconds}ms)");
            Thread.Sleep(PREPARE_ONION_MS);
            Console.WriteLine($"Onions are prepared \t\t\t({sw.ElapsedMilliseconds}ms)");
        }

        static void PreparePotato()
        {
            Console.WriteLine($"Started potato preparation... \t\t({sw.ElapsedMilliseconds}ms)");
            Thread.Sleep(PREPARE_POTATO_MS);
            Console.WriteLine($"Potato is prepared \t\t\t({sw.ElapsedMilliseconds}ms)");
        }

        static void PrepareMeat()
        {
            Console.WriteLine($"Started meat preparation... \t\t({sw.ElapsedMilliseconds}ms)");
            Thread.Sleep(PREPARE_MEAT_MS);
            Console.WriteLine($"Meat is prepared \t\t\t({sw.ElapsedMilliseconds}ms)");
        }

        static async Task CookCaserole()
        {
            Console.WriteLine($"Loading caserole into oven... \t\t({sw.ElapsedMilliseconds}ms)");
            await Task.Delay(COOKING_MS);
            Console.WriteLine($"Caserole is cooked \t\t\t({sw.ElapsedMilliseconds}ms)");

            return;
        }

        static void checkPassiveChoreCompletion(ref List<Task> passiveChores)
        {
            List<bool> completed = new List<bool>();
            foreach (var passiveChore in passiveChores)
            {
                completed.Add(passiveChore.IsCompleted);
            }

            // jako ruzno ali c#...
            int i = 0;
            foreach (var b in completed)
            {
                if (b)
                {
                    Console.WriteLine(passiveChoreMessage[i] + $"\t({sw.ElapsedMilliseconds}ms)");
                    passiveChores.RemoveAt(i);
                    passiveChoreMessage.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        delegate void activeChore();
        static List<string> passiveChoreMessage = new List<string> {
                $"Laundry taken out of the mashine",
                $"Dishes taken out of the mashine\t",
                $"Caserole taken out of the oven \t" };

        static async Task Main(string[] args)
        {
            sw.Start();
            List<activeChore> activeChores = new List<activeChore> { PrepareOnions, PreparePotato, PrepareMeat };
            Task laundryTask = WashLaundry();
            Task dishesTask = WashDishes();
            List<Task> passiveChores = new List<Task> { laundryTask, dishesTask };

            foreach (var chore in activeChores)
            {
                // pre izvrsavanja aktivnog zadatka proveri da li je neki od pasivnih zavrsen, bez da blokiram glavnu nit
                checkPassiveChoreCompletion(ref passiveChores);
                chore();
            }
            checkPassiveChoreCompletion(ref passiveChores);
            Task caseroleTask = CookCaserole();
            passiveChores.Add(caseroleTask);
            checkPassiveChoreCompletion(ref passiveChores);
            GoShopping();

            // ovde treba da blokiram nit dok se poslovi ne zavrse, stoga ne koristim funkciju
            while (passiveChores.Count > 0)
            {
                var finishedTask = await Task.WhenAny(passiveChores);
                var finishedTaskIndex = passiveChores.IndexOf(finishedTask);
                Console.WriteLine(passiveChoreMessage[finishedTaskIndex] + $"\t({sw.ElapsedMilliseconds}ms)");
                passiveChores.RemoveAt(finishedTaskIndex);
                passiveChoreMessage.RemoveAt(finishedTaskIndex);
            }

            Console.ReadLine();
        }
    }
}
