using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else
            {
                string quote = Convert.ToString((width + height + length) * weight);
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                Console.WriteLine("Thank You.");
                Console.ReadLine();
            }
        }
    }
}
