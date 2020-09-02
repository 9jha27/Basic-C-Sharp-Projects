using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step221ClassAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This method is called by passing in two numbers.");
            MathOperations.Addition(5, 7);

            int num1 = 6;
            int num2 = 7;
            Console.WriteLine("This method is called by specifying the parameters by name.");
            MathOperations.Addition(num1, num2);
            

            Console.ReadLine();

        }
    }
}
