using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            float x, y;
            char no; // no = Numeric Operator 
            float result = 0;

            Console.WriteLine("Zadej první číslo");
            while (!float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Zadej prosím platné číslo:");
            }

            Console.WriteLine("Zadej druhé číslo");
            while (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Zadej prosím platné číslo:");
            }

            Console.WriteLine("Zadej číselnou operaci (+, -, /, *)");
            while (!char.TryParse(Console.ReadLine(), out no) || (no != '+' && no != '-' && no != '*' && no != '/'))
            {
                Console.WriteLine("Zadej prosím platnou operaci:");
            }
            

            switch (no) // tohle by šlo udělat i přes if a else if viz zadání, ale tohle je asi jednodušší varianta.
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y != 0) 
                    {
                        result = x / y;
                    }
                    else
                    {
                        Console.WriteLine("Nulou přeci dělit nemůžeš :(!");
                        return;
                    }
                    break;
            }
            Console.WriteLine(result);
            Console.ReadKey();        

            //Ondřej Kupka 4.D 
        }
    }
}
