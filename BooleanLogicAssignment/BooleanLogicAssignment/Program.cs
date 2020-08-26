using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Approval Program for Car Insurance");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
         
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified for car insurance?");
            bool qualified = age > 15 && dui == "no" && tickets <= 3;
            Console.WriteLine(qualified);
           

            Console.ReadLine();
        }
    }
}
