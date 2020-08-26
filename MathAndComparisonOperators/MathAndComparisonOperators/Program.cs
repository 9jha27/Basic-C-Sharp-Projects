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
            string hourlyRate = Console.ReadLine();
            int rate = Convert.ToInt32(hourlyRate);

            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek = Console.ReadLine();
            int hrWeek = Convert.ToInt32(hoursPerWeek);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int rate2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("How many hours do you work per week?");
            string hoursPerWeek2 = Console.ReadLine();
            int hrWeek2 = Convert.ToInt32(hoursPerWeek2);
            Console.WriteLine("Annual salary of Person 1: " +
                "31,200");

            Console.WriteLine("Annual salary of Person 2: " +
                "41,600");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = 31200 > 41600;
            Console.WriteLine(compare);
            Console.ReadLine();


        }
    }
}
