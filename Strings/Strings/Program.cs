using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. " + "What is " + "your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Here's an example of your name in all uppercase:");
            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hi, my name is Ashliegh. ");
            sb.Append("I'm 28 years old.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
