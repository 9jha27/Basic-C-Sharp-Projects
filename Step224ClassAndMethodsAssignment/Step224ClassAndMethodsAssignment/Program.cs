using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Step224ClassAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           MathOperation mathop = new MathOperation(); //instantiate a new object of the class MathOperation

            //EXERCISE 1 - 4//
            Console.WriteLine("Please enter a whole number."); //have the user enter a number
            int input = Convert.ToInt32(Console.ReadLine()); //convert the input string to an int type

            mathop.Division(input); //Call the method on the inputted number

            Console.ReadLine(); //display the output on the screen

            //EXERCISE 5 - OVERLOAD A METHOD//
            Console.WriteLine("Please enter a number with a decimal.");
            double input2 = Convert.ToDouble(Console.ReadLine());
            mathop.Division(input2);

            Console.ReadLine();

            //OUT PARAMETER EXERCISE 4//
            MathOperation outParameter = new MathOperation(); //Create a method with out Parameters.
            int x, y; //local definition of variable
            
            outParameter.newOp(out x, out y);


            Console.WriteLine("The first value out is: " + x);
            Console.WriteLine("The second value out is: " + y);


            //STATIC CLASS EXERCISE 6//
            newOperation.Name();

            Console.ReadLine();



        }
    }
}
