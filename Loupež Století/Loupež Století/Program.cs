using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ONDŘEJ KUPKA 4.D


namespace Loupež_Století
{
    internal class Program 
    {
        static void Main(string[] args) //z mainu se prakticky hned přesuneme do Game.cs, Omlouvám se za to lehce pozdní odevzdání o pár hodin, ale stihl jsem to do sobotního rána tak snad to nevadí :))
        {
            string asciiArt = @"                                                                                                 
 _|                                                             
 _|          _|_|    _|    _|  _|_|_|      _|_|    _|_|_|_|     
 _|        _|    _|  _|    _|  _|    _|  _|_|_|_|      _|       
 _|        _|    _|  _|    _|  _|    _|  _|          _|         
 _|_|_|_|    _|_|      _|_|_|  _|_|_|      _|_|_|  _|_|_|_|     
                               _|  


             _|                _|              _|      _|       
   _|_|_|  _|_|_|_|    _|_|    _|    _|_|    _|_|_|_|           
 _|_|        _|      _|    _|  _|  _|_|_|_|    _|      _|       
     _|_|    _|      _|    _|  _|  _|          _|      _|       
 _|_|_|        _|_|    _|_|    _|    _|_|_|      _|_|  _|      "; 
                                                                
            Console.WriteLine(asciiArt);
            Console.WriteLine("\n\nVítej ve hře, shromáždi všechny důkazy a vyřeš případ!" + Environment.NewLine + "Pro prokačování stiskni libovolné tlačítko.");
            Console.ReadKey();
            Console.Clear();
            Game game = new Game();
            game.startGame();
            Console.ReadKey();
        }
    }
}
