using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step219ClassAndMethods
{
    public class MathOperation
    {
        public static int MathOperator(int num)
        {
            return num + 10;
        }

        //add more integers via method overloading
        public static int MathOperator(int num1, double num2)
        {
            return Convert.ToInt32((num1 + num2) * 10);
        }

        //take in a string and convert it to an integer if possible
        public static int MathOperator(int num1, double num2, string statement)
        {
            double converted = Convert.ToDouble(statement);
            return Convert.ToInt32((num1 + num2 + converted) % 10);
        }
        
    }
}
