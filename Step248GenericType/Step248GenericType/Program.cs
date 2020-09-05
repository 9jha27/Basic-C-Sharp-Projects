using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step248GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Likes = new Employee<string>();
            Likes.Things = new List<string>() { "books", "wine", "fans", "dog" };
            Employee<int> Quantity = new Employee<int>();
            Quantity.Things = new List<int>() { 5, 2, 3, 1 };

            for (int i = 0; i < Likes.Things.Count; i++)
            {
                Console.WriteLine(Likes.Things[i]);
            }
            for (int j = 0; j < Quantity.Things.Count; j++)
            {
                Console.WriteLine(Quantity.Things[j]);
            }



            Console.ReadLine();

        }
    }
}
