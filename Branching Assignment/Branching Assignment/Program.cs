using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh (in pounds)?");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Press the enter key to exit.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Please answer some questions about package dimension (in inches).");
            }
            

            Console.WriteLine("What is width of your package?");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is height of your package?");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the length of your package?");
            double length = Convert.ToDouble(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Press the enter key to end program.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                double volumeTimesWeight = width * height * length * weight;
                double quote = Math.Round(volumeTimesWeight / 100, 2);
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.ReadLine();
            }

            Console.WriteLine("Thank you!");
            Console.ReadLine();

            



        }
    }
}
