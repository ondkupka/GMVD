using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_prg_revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš první číslo");
            string x = Console.ReadLine();
            int z = int.Parse(x);
            Console.Clear();
            Console.WriteLine(x);

            Console.WriteLine("Napiš druhé číslo");
            string y = Console.ReadLine();
            int d = int.Parse(y);
            Console.Clear();
            Console.WriteLine(y);

            int sum = z+d;
            Console.WriteLine("Součet je: " + sum);

            int sub = z - d;
            Console.WriteLine("Součet je: " + sub);

            int multiply = z * d;
            Console.WriteLine("Součet je: " + multiply);

            Console.ReadKey();
        }
    }
}
