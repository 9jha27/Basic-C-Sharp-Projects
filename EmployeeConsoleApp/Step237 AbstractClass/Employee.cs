using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Employee : Person, IQuittable //inherits from Person class
    {
        public override void SayName() //SayName() method implemented inside Employee class
        {
            firstName = "Sample";
            lastName = "Student";
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Press enter to quit.");
        }

        public static bool operator ==(Employee person, Employee person2)
        {
            return (person.Id == person2.Id) ? true : false;
        }
        public static bool operator !=(Employee person, Employee person2)
        {
            return (person.Id != person2.Id) ? true : false;
        }

    }
}
