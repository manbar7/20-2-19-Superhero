using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class SuperMan : Human, IFly
    {
        public SuperMan(string name, int age) : base(name, age)
        {
            this.Speed = Speed;
        }

        public int Speed { get; private set; }
        public override string Name { get ; set ; }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }

        public void ActiveSuperPowers()
        {
            Fly();
        }

        public override string ToString()
        {
            return $"superman name is {this.Name} age {this.Age} speed {this.Speed}";
        }
    }
}
