using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? How many, 0 being none?");
            int dui = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = age >= 15 && speeding <= 3 && dui < 1;
            Console.Write(qualified);
            Console.ReadLine();


        }
    }
}
