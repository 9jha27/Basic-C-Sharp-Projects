using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public class MathOperation //inside our class "Math", we have ...
    {
        public static int Add(int age) //a method called add...
        {
            int add = age + 5;
            return add;
        }
        public static int Multiply(int age)
        {
            int multiply = age * 5;
            return multiply;
        }
        public static double Divide(double age)
        {
            double divide = age / 5;
            return divide;
        }

    }
}
