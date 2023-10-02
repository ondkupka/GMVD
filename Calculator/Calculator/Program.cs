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
            Console.WriteLine("Ahoj, s čím ti můžu pomoct?");
            Console.WriteLine("Zvol 1 pro základní číselné operace, 2 pro výpočet goneometrických funkcí, 3 pro čísla převod na binární kod, 4 pro mocnění");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.Clear();
                Algebra();
            }
            else if (answer == "2")
            {
                Console.Clear();
                Goniometrie();
            }
            else if (answer == "3")
            {
                Console.Clear();
                Binary();
            }
            else if (answer == "4")
            {
                Console.Clear();
                Power();
            }
            Console.ReadKey();        
        }
        static void Algebra()
        {
            float x, y; //x značí první číslo y značí druhé číslo 
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
        }
        static void Goniometrie()
        {
            char o;
            double degrees;
            double radians;
            double result = 0;
            Console.WriteLine("Zadej počet stupňů");
            while (!double.TryParse(Console.ReadLine(), out degrees))
            {
                Console.WriteLine("Zadej prosím platné stupně:");
            }
            Console.Clear();
            radians = degrees * Math.PI / 180; //převádíme ze stupňů na radiány 
            Console.WriteLine("1 pro sinus, 2 pro cosinus, 3 pro tangens, 4 pro cotangens");
            while (!char.TryParse(Console.ReadLine(), out o) || (o != '1' && o != '2' && o != '3' && o != '4'))
            {
                Console.WriteLine("Zadej prosím platnou operaci:");
            }
            Console.Clear();
                switch (o)
                {
                    case '1':
                        result = Math.Sin(radians);
                        break;
                    case '2':
                        result = Math.Cos(radians);
                        break;
                    case '3':
                        result = Math.Tan(radians);
                        break;
                    case '4':
                        result = 1 / Math.Tan(radians);
                        break;
                }
                Console.WriteLine(result);
        }
        
        static void Binary()
        {
            string input;
            string result;
            int num;
            Console.WriteLine("Zadej číslo, které chceš převést na binární kod");
            input = Console.ReadLine();
            if (Int32.TryParse(input.ToString(), out int number))
            {
                num = Convert.ToInt32(input);
                result = Convert.ToString(num, 2);
                Console.WriteLine("Výsledek převodu je: " + result);
            }
        }

        static void Power()
        {
            float x, y; // proměná x je základ, proměná y exponent 
            double result = 0;
             

            Console.WriteLine("Zadej prosím základ");
            while (!float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Zadej prosím platné číslo:");
            }

            Console.WriteLine("Zadej prosím exponent na který chceš mocnit");
            while (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Zadej prosím platný exponent:");
            }

            result = Math.Pow(x, y);
            Console.WriteLine("Výsledek " + x + "^" + y + " je " + result);
        }
    }
}

//Ondřej Kupka 4.D 