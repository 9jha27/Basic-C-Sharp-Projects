using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Laura", "Tom", "Tobi", "Wen", "Stephanie" }; //instantiating string Array with values

            Console.WriteLine("Pick a number between 0 and 4, inclusive"); //asking user to input an index number
            int indexStr = Convert.ToInt32(Console.ReadLine());
            if (indexStr >= 0 && indexStr <= 4)
            {
                Console.WriteLine("You selected " + stringArray[indexStr] + " as your new team member!"); //reading the input and printing
                Console.ReadLine();
            }
            else if (indexStr < 0 || indexStr > 4)
            {
                Console.WriteLine("You picked a number outside the range. Please print a number between 0 and 4.");
                int indexStrElse = Convert.ToInt32(Console.ReadLine());
                if (indexStrElse >= 0 && indexStrElse <= 4)
                {
                    Console.WriteLine("You selected " + stringArray[indexStrElse] + " as your new team member!"); //reading the input and printing
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You picked another number outside of the range. Please move on to the next question");
                    Console.ReadLine();
                }
            }


            Console.WriteLine("Pick a number between 0 and 6, inclusive."); //asking user to input an index number
            int[] intArray = { 5, 10, 7, 18, 29, 30, 32 }; //instantiating integer array with numbers
            int indexNum = Convert.ToInt32(Console.ReadLine());
            if (indexNum >= 0 && indexNum <= 6)
            {
                Console.WriteLine("Your favorite age is " + intArray[indexNum] + "."); //reading the input and printing
                Console.ReadLine();
            }
            else if (indexNum < 0 || indexNum > 6)
            {
                Console.WriteLine("You picked a number outside the range. Please print a number between 0 and 6.");
                int indexNumElse = Convert.ToInt32(Console.ReadLine());
                if (indexNumElse >= 0 && indexNumElse <= 6)
                {
                    Console.WriteLine("Your favorite age is " + intArray[indexNumElse] + "."); //reading input and printing
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You picked another number outside of the range. You're really bad at this!");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Pick an index number between 0 and 3, inclusive");
            List<string> stringList = new List<string> { "This is ", "a string ", "with four different ", "objects?" };
            int listNum = Convert.ToInt32(Console.ReadLine());
            if (listNum >= 0 && listNum <= 3)
            {
                Console.WriteLine("This string is in position " + listNum + ": " + stringList[listNum]);
            }
            else
            {
                Console.WriteLine("You didn't pick a number in the range. Byeeee!");
            }
            
            Console.ReadLine();

        }
    }
}
