using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Step220ClassAndMethodsAssignment
{
    public class MathOperation
    {

        public static int MathOperator(int num, int num2 = 2) //second parameter is optional
        {
            return num + num2;
        }
    }
}
