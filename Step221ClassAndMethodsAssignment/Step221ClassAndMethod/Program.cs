using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step221ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOp = new MathOperation();

            Console.WriteLine("Calling the method by passing in two numbers: ");
            mathOp.MathOperator(5, 4);

            Console.WriteLine("Calling the method by the parameter names: ");
            mathOp.MathOperator(num1: 3, num2: 6);

            Console.ReadLine();
        }
    }
}
