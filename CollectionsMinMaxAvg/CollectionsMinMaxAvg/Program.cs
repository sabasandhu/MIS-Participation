// Saba Sandhu 
// Participation: Min/Max/Avg 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
           string exam1grade;
           string exam2grade;
           string exam3grade;
            exam1grade = Console.ReadLine();
            exam2grade = Console.ReadLine();
            exam3grade = Console.ReadLine();
            
            // Creating an array of type int with a size of 4
            int[] examGrades = new int[4];
            string[] examNumber = { " One", "Two", "Three", "Four" };

            examGrades[0] = 95;
            examGrades[1] = 85;
            examGrades[2] = 92;
            examGrades[3] = 89;

            for (int i = 0; i < examGrades.Length; i++)
            {
                Console.WriteLine("The exam score for" + (examNumber) + " was " + (examGrades)); 
            }
            


            







            Console.ReadKey();
        }
    }
}
