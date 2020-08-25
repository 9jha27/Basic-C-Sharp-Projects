using System;


namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(help);
           
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(hours); //Do we need to covert this to an integer if we expect someone to answer with '3 hours' and not just '3'? 
           

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
          
        }
    }
}
