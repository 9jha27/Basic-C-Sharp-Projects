using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            int hrsPerWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            int hrsPerWeek2 = Convert.ToInt32(Console.ReadLine());

            int salary1 = rate * hrsPerWeek * 52;
            int salary2 = rate2 * hrsPerWeek2 * 52;
            Console.WriteLine("Annual salary of Person 1: " +
                salary1);

            Console.WriteLine("Annual salary of Person 2: " +
                salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = salary1 > salary2;
            Console.WriteLine(compare);
            Console.ReadLine();


        }
    }
}
