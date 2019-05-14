using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Flash : Human, IFlash
    {
       public Flash(int voltage, string name,int age) : base(name,age)
        {
            this.Voltage = voltage;
            this.Name = name;
        }

        public int Voltage { get; private set; }
        public override string Name { get ; set ; }

        public void ActiveSuperPowers()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {
            Console.WriteLine($"{Name} is fire lightning");
        }

        public override string ToString()
        {
            return $"flash name is {this.Name} age {this.Age} voltage {this.Voltage}";
        }
    }
}
