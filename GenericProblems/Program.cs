using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeProblems obj = new DateTimeProblems();
            int toContinue = 0;
            do
            {
                Console.WriteLine("Please enter the date");
                string date = Console.ReadLine();
                Console.WriteLine("Please enter the days");
                int days = Convert.ToInt32(Console.ReadLine());
                string newdate = obj.GetDateAfterDays(days, date);
                Console.WriteLine(newdate);
                Console.WriteLine("Press 1 for retest and 0 for exit");
                Int32.TryParse(Console.ReadLine(),out toContinue);

            } while (toContinue==1);
            
        }
    }
}
