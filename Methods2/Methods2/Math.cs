using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Math
    {
        public int Add(int a)
        {
            int result = a + 4;
            return result;
        }

        public decimal Add(decimal b)
        {
            decimal result = Decimal.ToInt32(b*4);
            return result;
        }

        public void Add(string c)
        {
            int len = c.Length;
            int num = len + 44;
            Console.WriteLine(num);
        }
    }
}
