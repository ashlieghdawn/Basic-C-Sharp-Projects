using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                if (userAge == 0)
                {
                    throw new ZeroException();
                }
                int born = 2020 - userAge;
                Console.WriteLine("You were born in {0}", born);
                Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("That was invalid");
                Console.ReadLine();
            }
            catch(NegativeException)
            {
                Console.WriteLine("Ages cannot be in negatives numbers.  It is impossible.");
                Console.ReadLine();
            }
            catch(ZeroException)
            {
                Console.WriteLine("You are not 0 years old.");
                Console.ReadLine();
            }

        }
    }
}
