using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math op = new Math();

            Console.WriteLine("Please enter a whole number: ");
            int mathA = op.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Please enter a decimal number: ");
            decimal mathB = op.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Please enter another number: ");
            string mathC = Console.ReadLine();
            op.Add(mathC);

            Console.WriteLine(mathA);
            Console.WriteLine(mathB);
            Console.WriteLine(mathC);
            Console.ReadLine();


        }
    }
}
