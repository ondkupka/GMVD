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
        public float result = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka v1.2");
            Console.WriteLine("Zvol: " + Environment.NewLine + "1 pro základní číselné operace" + Environment.NewLine + "2 pro výpočet goneometrických funkcí" + Environment.NewLine + "3 pro čísla převod na binární kod" + Environment.NewLine + "4 pro mocnění" + Environment.NewLine + "5 pro logaritmování čísla");
            string answer = Console.ReadLine();
            if (answer == "1") // tento if přehozuje mezi jednotlivými funkcemi kalkulačky 
            {
                Console.Clear();
                Basic();
            }
            else if (answer == "2")
            {
                Console.Clear();
                Goniometry();
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
            else if (answer == "5")
            {
                Console.Clear();
                Logarithm();
            }
            Console.ReadKey();        
        }
        static void Basic()
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

            switch (no) // tento switch mění mezi číselnými operátory -> dle mého jednodušší než přes if 
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
                    if (y != 0) // kontrola dělení nulou
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
        static void Goniometry()
        {
            char f; // f = funkce 
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
            Console.WriteLine("Zvol: 1 pro sinus, 2 pro cosinus, 3 pro tangens, 4 pro cotangens");
            while (!char.TryParse(Console.ReadLine(), out f) || (f != '1' && f != '2' && f != '3' && f != '4'))
            {
                Console.WriteLine("Zadej prosím platnou operaci:");
            }
            Console.Clear();
                switch (f) // přehazuje mezi funkcemi sinus/cosinus atd. 
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
            Console.WriteLine("Zadej číslo, které chceš převést na binární kod");
            string input = Console.ReadLine();
            if (Int32.TryParse(input.ToString(), out int number))
            {
                int num = Convert.ToInt32(input);
                string result = Convert.ToString(num, 2);
                Console.WriteLine("Výsledek převedený na binární kod je: " + result);
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
            Console.Clear();
            Console.WriteLine("Zadej prosím exponent na který chceš mocnit");
            while (!float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Zadej prosím platný exponent:");
            }
            Console.Clear();
            result = Math.Pow(x, y);
            Console.WriteLine("Výsledek " + x + "^" + y + " je " + result);
        }

        static void Logarithm()
        {
            float x;
            Console.WriteLine("Zvol: " + Environment.NewLine + "1 pro přirozený logaritmus" + Environment.NewLine + "2 pro desítkový logaritmus");
            string answer = Console.ReadLine();
            if (answer == "1") // tento if přehazuje mezi jednotlivými typy logaritmů
            {
                Console.Clear();
                Console.WriteLine("Zadej číslo, které chceš logaritmovat");
                while (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Zadej prosím platné číslo:");
                }
                double naturalnLogarithm = Math.Log(x);
                Console.Clear();
                Console.WriteLine("Výsledek přirozeného logaritmu je " + naturalnLogarithm);
            }
            else if (answer == "2")
            {
                Console.Clear();
                Console.WriteLine("Zadej číslo, které chceš logaritmovat");
                while (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Zadej prosím platné číslo:");
                }
                double decimalLogarithm = Math.Log10(x);
                Console.Clear();
                Console.WriteLine("Výsledek desítkového logaritmu je " + decimalLogarithm);
            }

            
        }

    }
}

//Ondřej Kupka 4.D 
/*Kalkulačka umí:
Základní číselné operace (+,-,*,/ )
Mocinit
Využívat goneometrické funkce (sinus, cosinus, tangenc, cotangenc)
Využívát desítkový i přirozený logaritmus
Převést číslo na binární kod
*/
