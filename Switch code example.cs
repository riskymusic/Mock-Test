using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine("\n Please enter a letter and i will tell you whether it is a vowel or not? ");
            string input = Console.ReadLine(); //String is the what we use to determine is correct//
            switch (input) //is used to open up a case statement which refers to you Vowel that is represented//

            {
                case "a": //you can use any number of cases within a switch statement 
                case "e": //Case is represented with a value statement "U" then represented with a colon :
                case "i":
                case "o":
                case "u":

                    Console.WriteLine($"{input} is a vowel"); //you then write line to represent whether it is a vowel or not
                    break; //use break to break out of the code if the statement isnt true
                    // "$" is a shortcut to utilise the string {input}, it will break if it is not true.
                default: //breaks to default which takes you to the next switch statement
                    Console.WriteLine($"{input} is a consonant"); //final reply to failed question above
                    break;//break is used to break you out of code 
            }
            Console.WriteLine("please press enter to exit."); //final statement to user 
            Console.ReadLine(); //Console.readline is used to read all above and not cancel out of code.
            
            
            
            
            
            
            
            //Console.WriteLine("\nPlease enter a letter and i will tell you if it is a vowel or not? ");
            //string input = Console.ReadLine();
            //switch (input)
            
            //case "a";
               //case "e";
                //case "i";
                //case "o";
               // case "u";
                   // Console.WriteLine($"{input} is a vowel");
                    //break;
                //default:
                    //Console.WriteLine($"{input} is a consonant");
                    //break;//
            
            //Console.WriteLine("please press enter to exit.");
            //Console.ReadLine();//
        }
    }
}
