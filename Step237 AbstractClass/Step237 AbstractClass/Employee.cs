using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step237_AbstractClass
{
    public class Employee : Person //inherits from Person class
    {
        public override void SayName() //SayName() method implemented inside Employee class
        {
            firstName = "Sample";
            lastName = "Student";
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
