using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Jesse", "Erik", "Daniel", "Adam"};
            Console.WriteLine("Please enter a last name for the kids:");
            string lastName = Console.ReadLine();

            for (int j = 0; j < names.Length; j++)
            {
                {
                    names[j] = names[j] + " " + lastName;
                }
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();
        }
    }
}
