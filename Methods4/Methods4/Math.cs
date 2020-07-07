using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    public class Math
    {
        public static void ModifyValue(int i, int x)
        {
            i = i * 3;
            Console.WriteLine("Your first number was tripled to = {0}", i);
            Console.WriteLine("Your second number stayed the same = {0}", i);
            return;
        }
        
    }
}
