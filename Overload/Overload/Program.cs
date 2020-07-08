using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 1;

            Employee employee2 = new Employee();
            employee2.Id = 2;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();
        }
    }
}
