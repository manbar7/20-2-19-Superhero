using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class SpiderMan : Human,IClimb
    {
        public SpiderMan(int webLeft,string name,int age) : base(name,age)
        {
            this.WebLeft = webLeft;
           
        }

        public int WebLeft { get; private set; }
        public override string Name { get; set ; }

        public void ActiveSuperPowers()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine($"{ Name} is climbing" );
        }

        public override string ToString()
        {
            return $"spiderman name is {this.Name} age {this.Age} webs {this.WebLeft}";
        }
    }
}
