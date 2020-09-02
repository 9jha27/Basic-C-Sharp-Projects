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

            int output = MathOperation.MathOperator(input);
            Console.WriteLine("Your number plus 10 is: " + output);
            Console.ReadLine();

            Console.WriteLine("Please pick a decimal number.");
            double input2 = Convert.ToDouble(Console.ReadLine());
            int output2 = MathOperation.MathOperator(input, input2);
            Console.WriteLine("Your first number plus your second number multiplied by ten is: " + output2);
            Console.ReadLine();

            Console.WriteLine("Please pick a third number.");
            string input3 = Console.ReadLine();
            int output3 = Convert.ToInt32(MathOperation.MathOperator(input, input2, input3));
            Console.WriteLine("Your first number plus your second number plus your third number divided by ten has a remainder of: " + output3);
            Console.ReadLine();
        }
    }
}
