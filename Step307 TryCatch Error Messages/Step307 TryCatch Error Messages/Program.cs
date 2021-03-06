﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step307_TryCatch_Error_Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            bool inputBirth = false;
            while (!inputBirth)
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    int inputAge = Convert.ToInt32(Console.ReadLine());
                    DateTime current = DateTime.Now;
                    int birthYear = current.Year - inputAge;

                    if (inputAge <= 0)
                    {
                        throw new ZeroAndNegativeNumberException();
                    }
                    Console.WriteLine("You were born in either " + birthYear + " or in " + (birthYear - 1) + ", depending on your birth month an date.");
                    Console.ReadLine();
                    return;
                }
                catch (ZeroAndNegativeNumberException)
                {
                    Console.WriteLine("Please enter your true age. You cannot possibly be a negative age or zero years old.");
                    Console.ReadLine();
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("It looks like there is an error. Double check that you entered your age in integers.");
                    Console.ReadLine();
                   
                }
            }
        }

        public class ZeroAndNegativeNumberException : Exception
        {
            public ZeroAndNegativeNumberException()
                : base() {}
        }
    }
}
