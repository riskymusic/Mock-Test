using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a letter and i will tell you whether its a vowel or not: y");
            string input = Console.ReadLine().ToUpper();
            string input2 = "Jacob";
            input2.ToUpper();
            switch (input)
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine($"{input} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{input} is not a vowel");
                    break;
            }
            Console.WriteLine("press enter to exit");
            Console.ReadLine();

      
            
               












            }
    }
}
