using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many stars are there on the U.S. flag?");
            int numberOfStars = Convert.ToInt32(Console.ReadLine());
            bool answer = numberOfStars == 50;

            do
            {
                switch (numberOfStars)
                {
                    case 48:
                        Console.WriteLine("Oh, so close! Try again!");
                        Console.WriteLine("How many stars?");
                        numberOfStars = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 49:
                        Console.WriteLine("Getting hotter... try again!");
                        Console.WriteLine("How many stars?");
                        numberOfStars = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("Correct!");
                        answer = true;
                        break;
                    default:
                        Console.WriteLine("Your guess of " + numberOfStars + " stars is incorrect. Try again!");
                        Console.WriteLine("How many stars?");
                        numberOfStars = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!answer);
            


            Console.WriteLine("How many toppings of pizza would you like?");
            int toppings = Convert.ToInt32(Console.ReadLine());
            
            while (toppings >= 0)
            {
                switch(toppings)
                {
                    case 0:
                        Console.WriteLine("Just plain old cheese. Or just bread.");
                        break;
                    case 1:
                        Console.WriteLine("1 topping.");
                        break;
                    case 2:
                        Console.WriteLine("2 toppings.");
                        break;
                    case 3:
                        Console.WriteLine("3 toppings.");
                        break;
                    case 4:
                        Console.WriteLine("4 toppings.");
                        break;
                    default:
                        Console.WriteLine("Woah! I'm totally judging the number of toppings you want on your pizza!");
                        break;
                }
                Console.Read();
                System.Environment.Exit(1);
            }
        }
    }
}
