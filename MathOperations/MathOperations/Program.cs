using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number under 10,000,000: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int multiply = num * 50;
            Console.WriteLine(multiply);
            Console.ReadLine();

            Console.WriteLine("Pick another number between 0 and 2500: ");
            string newInput = Console.ReadLine();
            int newNum = Convert.ToInt32(newInput);
            int addition = newNum + 25;
            Console.WriteLine(addition);
            Console.ReadLine();

            Console.WriteLine("Pick another number between 0 and 2500: ");
            string secondInput = Console.ReadLine();
            int secondNum = Convert.ToInt32(secondInput);
            double division = secondNum / 12.5;
            Console.WriteLine(division);
            Console.ReadLine();

            Console.WriteLine("Pick another number under 10,000,000: ");
            string compareInput = Console.ReadLine();
            int numInput = Convert.ToInt32(compareInput);
            bool greaterThan = numInput > 50;
            Console.WriteLine(greaterThan);
            Console.ReadLine();

            Console.WriteLine("Pick another number under 10,000,000: ");
            string modInput = Console.ReadLine();
            int modulInput = Convert.ToInt32(modInput);
            int remainder = modulInput % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
