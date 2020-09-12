using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step290_Logging_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number.");
            string userInput = Console.ReadLine();
            using (StreamWriter input = new StreamWriter(@"C:\Users\Jina\Desktop\log.txt", true))
            {
                input.WriteLine(userInput);
            }
            Console.WriteLine(userInput + " is now logged in your txt file. Thank you!");
            Console.ReadLine();
        }
    }
}
