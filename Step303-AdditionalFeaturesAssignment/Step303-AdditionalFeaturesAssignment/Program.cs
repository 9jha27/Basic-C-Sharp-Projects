using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Step303_AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fName = "Laura";
            var daysOfWeek = new string[7]
            {
                "Sunday","Monday,","Tuesday","Wednesday","Thursday","Friday","Saturday"
            };
            var studentSchedule = new Schedule(fName, daysOfWeek[6]);
            var studentSchedule2 = new Schedule(fName);

            //Console.WriteLine(studentSchedule + "\n" + studentSchedule2);
            
        }


}   
    
    
}
