using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> Employee1 = new Employee<string>();
            Employee1.Things = new List<string>() { "bottles", "desks", "artwork" };

            Employee<int> Employee2 = new Employee<int>();
            Employee2.Things = new List<int>() { 2, 4, 6, 8 };

            foreach (var Thing in Employee1.Things)
            {
                Console.WriteLine(Thing);
            }

            foreach (var Thing in Employee2.Things)
            {
                Console.WriteLine(Thing);
            }
            Console.ReadLine();
        }
    }
}
