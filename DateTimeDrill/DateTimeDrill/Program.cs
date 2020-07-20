using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current Time: " + currentTime);

            Console.WriteLine("\nPlease input a number: ");
            int userHour = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = currentTime.AddHours(userHour);
            Console.WriteLine("In {0} hours it will be exactly: ", userHour);
            Console.Write(futureTime);

            Console.ReadLine();
        }
    }
    }
}
