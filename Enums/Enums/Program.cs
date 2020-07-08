using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string value = Console.ReadLine().ToUpper(); //assign value to a var of that enum data type just created
            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine("Have a great day.");
                Console.ReadLine();
            }

            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }

        public enum DaysOfTheWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }
}
