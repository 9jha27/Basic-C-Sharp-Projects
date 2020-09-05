using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.SayName();

            IQuittable quit = new Employee();
            quit.Quit();


            Person person = new Employee() { firstName = "Laura", lastName = "Ha", Id = 4698765 };
            Person person2 = new Employee() { firstName = "Christine", lastName = "Ha", Id = 4699854 };

            Console.WriteLine(person.Equals(person2));
            Console.ReadLine();

        }
    }
}
