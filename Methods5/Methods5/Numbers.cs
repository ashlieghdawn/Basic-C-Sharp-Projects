using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Numbers
    {
        public void Division(int a)
        {
            int result = a / 2;
            Console.WriteLine("The number you entered divided by 2 is {0}", result);
        }

        public void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("The first number divided by the second number is {0}", result);
        }

        public void Changes(out int c)
        {
            int num = 10;
            c = num;
        }
    }
}
