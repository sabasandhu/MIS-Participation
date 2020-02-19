// Saba Sandhu 
//random generator example 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particpation_Programming
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine(" Enter Heads or Tails >> ");
            string choice = Console.ReadLine();

            int outcome = 0;

         if (choice == "Heads")
            {
                outcome = 0 ;
            }
        else
            {
                outcome = 1 ;
            }

          Random rand = new Random();
            //use the next method on 'rand' and pass in 0,2 to generate a number that is 0 or 1 
            int randomNumber = rand.Next(0, 2);
            string answer = Console.ReadLine();
        if (randomNumber = choice) ;
            {
                answer = "correct";
            } 
        else 
            {
                answer = "incorrect"; 
            }
        Console.ReadKey(); // Prevent the application from closing until we press a key
        }
    }
}
