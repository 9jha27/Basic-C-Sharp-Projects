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
        public static int MathOperator(decimal num1)
        {
            return Convert.ToInt32((num1) * 10);
        }

        //take in a string and convert it to an integer if possible
        public static int MathOperator(string num1)
        {
            double converted = Convert.ToDouble(num1);
            return Convert.ToInt32((converted) % 10);
        }
        
    }
}
