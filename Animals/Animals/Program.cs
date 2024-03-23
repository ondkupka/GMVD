using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Animals
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;

            public virtual void AnimalNoise()
            {
                Console.WriteLine("hha");
            }
        }

        
        class Dog : Animal
        {
            public int numberofPuppies;
            public string race;

            public override void AnimalNoise()
            {
                Console.WriteLine("hha");
            }
        }

        class Cat : Animal {
            public bool lovesMilk;
            public string boolColor;

            public override void AnimalNoise()
            {
                Console.WriteLine("hha");
            }
        }

        static void Main(string[] args)
        {
         Dog newDog = new Dog();
            newDog.name = "zeryk";
            newDog.race = "retrivr";
            Cat newCat = new Cat();
            newCat.name = "micka";
            newCat.lovesMilk = true;
        }
    }
}
