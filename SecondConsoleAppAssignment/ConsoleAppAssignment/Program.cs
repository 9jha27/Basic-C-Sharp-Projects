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
            string beginning = "This is the beginning, ";
            string middle = "the middle, ";
            string end = "and the end!";

            string together = beginning + middle + end;
            Console.WriteLine(together); //three strings concatenated
            

            together = together.ToUpper(); //to Uppercase
            Console.WriteLine(together);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder(); //creating an instance of a stringbuilder class
            sb.Append("This is the first sentence of my StringBuilder.");
            sb.Append("\nThis is the second sentence of my StringBuilder.");
            sb.Append("\nThe third...");
            sb.Replace("the", "my");
            sb.Append("\nIs this what I am supposed to be doing in this assignment?");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
