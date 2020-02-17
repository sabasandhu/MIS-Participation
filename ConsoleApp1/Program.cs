//String Manipulation 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static string msg = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
          static void Main(string[] args)
        {
            Console.WriteLine(msg);

            Console.WriteLine("What word would you like to look for? >>");
            string lookupword = Console.ReadLine();
            Console.WriteLine($"What word would you like to change {lookupword} to? >>");
            string replaceword = Console.ReadLine();

            bool doesContainWord = msg.Contains(lookupword);

            if (doesContainWord == true)
            {

                //The sentence has the lookupword in it
                string newSentence = msg.Replace(lookupword, replaceword);
                Console.WriteLine(newSentence);
            }
            else
            {
                //The sentence DOES NOT have the lookupword in it 
                Console.WriteLine($"Sorry, I could not find your word {lookupword}.");
                { for (int i = lookupword.Length - 1; i >=0; i--)
                    {
                        Console.Write(lookupword[i]);
                    }

            }
                Console.WriteLine(); 
            Console.ReadKey();




    }
    }
    }
}
