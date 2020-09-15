using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Step303_AdditionalFeaturesAssignment
{
    public class Schedule
    {
        public Schedule(string name) : this(name, "Wednesday")
        {
        }

        public Schedule(string name, string dayOfWeek)
        {
            Console.WriteLine(name + " is set to have an audition on " + dayOfWeek + ".");
            Console.ReadLine();
        }
    }
}
