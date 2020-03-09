// Saba Sandhu 
// FunctionsCalculator 
/* -Add
            The add method should accept two parameters, both of type double, and should have a return type of double.
            The add method should add the first parameter by the second parameter(e.g.val1 + val2) and return the result
          -Subtract
            The subtract method should accept two parameters, both of type double, and should have a return type of double.
            The subtract method should subtract the first parameter by the second parameter(e.g.val1 -val2) and return the result
          -Multiply
            The multiply method should accept two parameters, both of type double, and should have a return type of double.
            The multiply method should multiply the first parameter by the second parameter(e.g.val1* val2) and return the result
          -Divide
            The divide method should accept two parameters, both of type double, and should have a return type of double.
            The divide method should divide the first parameter by the second parameter(e.g.val1 / val2) and return the result
          -DeveloperInformation
            The DeveloperInformation method should accept three parameters, a string for the developers name, a string for the class name, and a string for the date of writing.The method should have a return type of void..
            The DeveloperInformation method should use the three parameters to output a string on the console describing who wrote the application, for what class, and on what date */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1;
            double var2;

            double sum = Add( var1, var2);
            
            double difference = Subtract(var1, var2 );

            // -Add

            //      -Subtract

            //    -Multiply

            //  -Divide

            // -DeveloperInformation


        }

        private static double Add(double var1, double var2)
        {
            throw new NotImplementedException();
        }

        private static double Subtract(object firstNum, object secondNum)
        {
            throw new NotImplementedException();
        }
    }
}
