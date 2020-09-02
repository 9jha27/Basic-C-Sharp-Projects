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

            /*Console.WriteLine("Pick a second number if you wish.");
            string input2 = Console.ReadLine();*/

            Console.WriteLine(MathOperation.MathOperator(input1));

            Console.ReadLine();
        }
    }
}
