using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCompare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1, what is your hourly rate?");
            decimal rateOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 1, how many hours per week do you work?");
            decimal hoursOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2, what is your hourly rate?");
            decimal rateTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2, how many hours per week do you work?");
            decimal hoursTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person One:");
            Console.WriteLine(rateOne * hoursOne * 52);
            Console.WriteLine("Annual Salary of Person Two:");
            Console.WriteLine(rateTwo * hoursTwo * 52);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool makesMore = (rateOne * hoursOne * 52) > (rateTwo * hoursTwo * 52);
            Console.Write(makesMore);
            Console.ReadLine();

        }
    }
}
