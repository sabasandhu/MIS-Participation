//Array AND Lists example 

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
            // Create an array of type int with a size of 3 
            int[] studentIds = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" }; // these two arrays are parallel, values at the same INDEX correlate to each other 


            //      [0]      [1]       [2]
            //[0][1][2]
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            // INDEX OUT OF RANGE BC WE ONLY HAVE SPACE FOR 3 VALUES -- studentIds[3] = 4;

            Console.WriteLine($"Student with ID {studentIds[0]} has a name of {studentNames[0]}");
            for (int i = 0; i < studentIds.Length; i++) // Could also do studentNames.Length as they are PARALLEL
            {
                Console.WriteLine($"Student with ID {studentIds[i]} has a name of {studentNames[i]}");
            }
            // DO THE SAME THING BUT WITH LISTS

            List<int> studIds = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>() { "Lakin", "Grant", "Eric" };
            //studNames.Add("Lakin");
           // studNames.Add("Grant");
           // studNames.Add("Eric");

            for (int i = 0; i< studIds.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIds[i]} has a name of {studNames[i]}");
            }
            //COMBINE ARRAY DATA AND LIST  INTO A DICTIONARY
            Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Adam");
            for (int i = 0; i < studentIds.Length; i++) // Could also do studentNames.Length as they are PARALLEL
            {
                if (students.ContainsKey(studentIds[i]) ==  false)

                    students.Add(studentIds[i], studentNames[i]));
            }
        if (students.ContainsKey(studIds[i]) == false)
            (
            students.Add(studIds[if], studNames[i]);
            )
        Console.WriteLine("MADE IT THRU ALIVE");
                Console.ReadKey();

        }
    }
}
