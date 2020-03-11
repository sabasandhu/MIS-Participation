using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade, answer;
            List<double> scores = new List<double>();

            do
            {
                Console.WriteLine($"Please enter your grade >>");
                grade = Console.ReadLine();
                double es = Convert.ToDouble(grade);
                scores.Add(es);
                //scores.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you want to input another grade? yes/no >>");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            double sum = 0; // this is often referred to as an ACCUMULATOR variable
            double minimum = scores[0];
            double maximum = scores[0];
          

            double average = sum / scores.Count;

            Console.WriteLine($"Your average for the {scores.Count} exam grades is {average.ToString("N3")}.");
            

            Console.ReadKey();
        }
    }
}
