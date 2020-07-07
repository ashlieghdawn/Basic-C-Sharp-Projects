using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));

            Math.ModifyValue(num1, num2);
            Math.ModifyValue(i: num1, x: num2);
            Console.ReadLine();
        }
    }
}
