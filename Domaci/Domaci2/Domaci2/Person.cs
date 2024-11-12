using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domaci2
{
    enum gender {
        MALE,
        FEMALE
    };

    internal class Person
    {
        public gender gender;
        public int id;

        public Person(gender gender, int id)
        {
            this.gender = gender;
            this.id = id;
        }
    }
}
