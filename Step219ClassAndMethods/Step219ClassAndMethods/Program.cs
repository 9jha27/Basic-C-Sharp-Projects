using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step219ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a whole number.");
            int input = Convert.ToInt32(Console.ReadLine());

            MathOperation mathop = new MathOperation();
            int output = mathop.MathOperator(input);
            Console.WriteLine("Your number plus 10 is: " + output);
            Console.ReadLine();

            Console.WriteLine("Please pick a decimal number.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());

            MathOperation mathop2 = new MathOperation();
            int output2 = mathop2.MathOperator(input2);
            Console.WriteLine("Your number multiplied by ten is: " + output2);
            Console.ReadLine();

            Console.WriteLine("Please pick a third number.");

            MathOperation mathop3 = new MathOperation();
            string input3 = Console.ReadLine();
            int output3 = Convert.ToInt32(mathop3.MathOperator(input3));
            Console.WriteLine("Your number divided by ten has a remainder of: " + output3);
            Console.ReadLine();
        }
    }
}
