using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    abstract class Human
    {
        abstract public string Name { get; set; }
        private int age;

        public int Age {
            get
            {
                return this.age;
            }
        }

        public Human(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
    }
}
