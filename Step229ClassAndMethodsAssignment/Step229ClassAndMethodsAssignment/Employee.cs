using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step229ClassAndMethodsAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            FirstName = "Sample";
            LastName = "Student";
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Press enter to quit.");
        }

        public static Employee operator== (Employee Id, Employee name)
        {
            return name == Id;
        }
    }
}
