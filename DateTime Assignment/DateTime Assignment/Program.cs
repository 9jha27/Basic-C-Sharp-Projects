using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number.");
            
            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("It will be " + DateTime.Now.AddHours(userInput) + " " + userInput + " hours from now."); 
            Console.ReadLine();
        }
    }
}
