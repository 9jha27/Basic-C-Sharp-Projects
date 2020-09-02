using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Step224ClassAndMethodsAssignment
{
    public class MathOperation
    {
        public void Division(int num1)
        {
            Console.WriteLine("The number divided by 2 is: " + num1 / 2);
        }

        public void Division(double num1)
        {
            Console.WriteLine("The number divided by 2 is: " + num1 / 2);
        }

        public void newOp(out int x, out int y)
        {
            x = 50;
            y = 60;
        }

    }
    static class newOperation
    {
        public static string fName = "Laura";
        public static string lName = "Ha";
        public static void Name()
        {
            Console.WriteLine("This was written using a static class: " + fName + " " + lName);
        }

    }
}
