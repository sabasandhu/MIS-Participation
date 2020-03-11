//Saba Sandhu 
//Collections 2 Participation 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of type int with a size of 3 

            Console.WriteLine(" Enter 3 course subject abbreviations on separate lines");
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine(" Enter the correlating course numbers with the subjects entered above, in the same order on separate lines");
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            int[] CourseNumber = new int[3];
            string[] subject = { "MIS", "ACCT", "SPAN" }; //these 2 arrays are parrallel, values at the same INDEX sorrelate with each other 

            //  [0]         [1]         [2]
            // ["MIS"]      ["ACCT"]    ["SPAN"]

            CourseNumber[0] = 1;
            CourseNumber[1] = 2;
            CourseNumber[2] = 3;



            Console.ReadKey();
        }
    }
}
