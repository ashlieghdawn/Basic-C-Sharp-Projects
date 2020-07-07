using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    public class Math
    {
        public void Addition(int a, int b = 0)
        {
            int result = a + b;
            Console.WriteLine("First Number: {0}", a);
            Console.WriteLine("Second Number: {0}", b);
            Console.WriteLine("Add up to be: {0}", result);
        }
    }
}
