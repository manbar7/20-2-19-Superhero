using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperMan Clark = new SuperMan("Clark", 39);
            SpiderMan Peter = new SpiderMan(3, "Peter", 29);
            Flash gordon = new Flash(9, "Gordon", 31);

            ISuperHero[] SuperHeroes = new ISuperHero[] { Clark, Peter, gordon };

            foreach (ISuperHero item in SuperHeroes)
            {
                ActiveHero(item);

            }



            
        }

        static void ActiveHero(ISuperHero S)
        {
            S.ActiveSuperPowers();
               
        }

        static void IdentifyHero(ISuperHero S)
        {
            if (S is SuperMan)
                Console.WriteLine("its a superman");
            if (S is SpiderMan)
                Console.WriteLine("Its a spiderman");
            else
                if (S is Flash)
                Console.WriteLine("its a Flash");
            else
                Console.WriteLine();

        }

        static void GetMoreHeroData(ISuperHero hero)
        {
            SuperMan superman = hero as SuperMan;
            if (superman != null)
                Console.WriteLine(superman.Speed);
            SpiderMan Spider = hero as SpiderMan;
            if (Spider != null)
                Console.WriteLine(Spider.WebLeft);
            Flash Flashy = hero as Flash;
            Console.WriteLine(Flashy.Voltage);


        }

    }
}
