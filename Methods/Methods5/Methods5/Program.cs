using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers op = new Numbers();

            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            op.Division(num1);

            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            op.Division(num1, num2);

            Console.WriteLine("Please enter another number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            op.Changes(out num3);
            Console.WriteLine("After calling a method, the value of it is now: {0}", num3);
            Console.ReadLine();

            Console.WriteLine("What's the best hike in Oregon?  " + Hike.BestHike);
            Console.WriteLine("Definitely, " + Hike.Why);
            Console.ReadLine();
        }
    }
}
