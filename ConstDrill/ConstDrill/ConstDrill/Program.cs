using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string currentYear = "2020";
            Console.WriteLine("We are in the year {0}", currentYear);
            Console.ReadLine();

            var yearEvents = new { Events = "Corona Virus, Killers Bees, Racial Justice Protests", Causes = "guidelines not being followed and injustice in our justice system"};
            Console.WriteLine("2020 Events\n" + yearEvents);
            Console.ReadLine();
        }
    }
}
