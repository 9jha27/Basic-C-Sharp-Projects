using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employees
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int empID { get; set; }

        public Employees(string fname, string lname, int id)
        {
            firstName = fname;
            lastName = lname;
            empID = id;
        }
    }
}
