using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
            //get two dates input
            Console.WriteLine("Please enter the first date in Day/Month/Year");
            string input1 = Console.ReadLine();
           
            Console.WriteLine("Please enter the second date in Day/Month/Year");
            string input2 = Console.ReadLine();
            

            DateTime date1 = DateTime.Parse(input1);
            DateTime date2 = DateTime.Parse(input2);

            TimeSpan difference = date1 - date2;

            int days = difference.Days;
            Console.WriteLine("Years: " + days / 365);
            days = days % 365; 
            Console.WriteLine("Months: " + days / 30);
            days = days % 30;
            Console.WriteLine("Days: " + days);
            Console.WriteLine("Hours: " + difference.Hours);
            Console.WriteLine("Minutes: " + difference.Minutes);
            Console.WriteLine("Seconds: " + difference.Seconds);
            
            Console.WriteLine("Press any key.....");
                Console.ReadKey();
            }
            








        }
    }
}
