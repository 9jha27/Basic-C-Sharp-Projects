using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            int add = MathOperation.Add(age);
            Console.WriteLine("You will be " + add + " years old in five years!");

            int multiply = MathOperation.Multiply(age);
            Console.WriteLine("Five times your age is " + multiply);

            double divide = MathOperation.Divide(age);
            Console.WriteLine("Your age divided by 5 is " + divide);

            Console.ReadLine();

        }
    }
}
