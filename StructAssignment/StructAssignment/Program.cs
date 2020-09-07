using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number;
            number.Amount = 3.265468856688M;

            Console.WriteLine(number.Amount);
            Console.ReadLine();

            
        }

        struct Number
        {
            public decimal Amount;
        }
    }
}
