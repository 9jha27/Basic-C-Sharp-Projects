using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the current day of the week.");

            string input = Console.ReadLine();
            try
            {
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);
                Console.WriteLine("It is a " + day + " today!");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            
            Console.ReadLine();
        }
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
