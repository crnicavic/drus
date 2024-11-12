using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domaci2
{
    internal class Program
    {
        public const int TOILET_CAPACITY = 4;
        public const int PEOPLE_COUNT = 30;
        public const int M = 1;

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 30; i++)
            {
                if (i > 28) {
                    people.Add(new Person(gender.MALE, i));
                } else {
                    people.Add(new Person(gender.FEMALE, i));
                }

            }
            Toilet.SimulateToilet(people);
            Console.ReadLine();
        }

    }
}
