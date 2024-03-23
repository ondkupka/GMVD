using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridy
{
    internal class Program
    {

        class Human
        {
            public int age;
            public int height;
            public int weight;
            public string name;
            public string eyeColor;
            public string hairColor;
        }

        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.age = 1;
            human1.height = 100;
            human1.weight = 100;
            human1.name = "Test";
            human1.eyeColor = "Blue";
            human1.hairColor = "White";
        }
    }
}
