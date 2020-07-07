using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math op = new Math();
            Console.WriteLine("Please enter a number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("Please enter another number {optional} or type x to continue:");
                int numB = Convert.ToInt32(Console.ReadLine());
                op.Addition(numA, numB);
            }
            catch(Exception ex)
            {
                op.Addition(numA);
            }

            Console.ReadLine();
        }
    }
}
