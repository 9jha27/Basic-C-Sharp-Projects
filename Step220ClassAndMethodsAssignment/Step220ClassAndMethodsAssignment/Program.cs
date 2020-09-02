using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Step220ClassAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick your first number.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a second number if you wish. This is not required.");
            string userInput2 =  Console.ReadLine();

            MathOperation mathop = new MathOperation();
            if(string.IsNullOrEmpty(userInput2))
            {
                Console.WriteLine(mathop.MathOperator(input1));
            }
            else
            {
                int input2 = Convert.ToInt32(userInput2);
                Console.WriteLine(mathop.MathOperator(input1, input2));
            }

            Console.ReadLine();
        }
    }
}
