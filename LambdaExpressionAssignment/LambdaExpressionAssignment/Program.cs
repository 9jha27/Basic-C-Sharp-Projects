using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>()
            {
                new Employees("Joe", "Evans", 1),
                new Employees("Laura", "Ha", 2),
                new Employees("Tom", "vSchaik", 3),
                new Employees("Tobi", "Ha", 4),
                new Employees("Joe", "Faggione", 5),
                new Employees("Stephanie", "Ruggles", 6),
                new Employees("Lani", "Ha", 7),
                new Employees("Eli", "Stewey", 8),
                new Employees("Jessica", "Kim",9),
                new Employees("James", "Johnson", 10)
            };

        List<Employees> sameName = new List<Employees>();
        foreach (Employees emp in employee)
            {
                
                if (emp.firstName == "Joe")
                {
                    sameName.Add(emp);
                }
            }

            List<Employees> newSameName = employee.Where(x => x.firstName == "Joe").ToList();

            List<Employees> overFiveId = employee.Where(x => x.empID > 5).ToList();

        }
    }

}
