using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    List<int> numbers = new List<int> { 5, 3, 2, 6, 7, 4, 1 };
                    Console.WriteLine("Please pick a whole number.");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in numbers)
                    {
                        Console.WriteLine(number / userInput);
                    }

                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please do not divide by zero.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: You did not enter a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }

            } while (true);
           
        }
    }
}
