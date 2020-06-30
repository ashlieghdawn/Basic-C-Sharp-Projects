using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    class Program
    {
        static void Main()
        {
            // prompt one
            
            string[] stringArray = new string[] { "coffee", "bean", "caffeine", "sprouts" };
            Console.WriteLine("There is an array of strings, pick a number to print one:");
            int string1 = Convert.ToInt32(Console.ReadLine());
            if (string1 <= 3 && string1 >= 0)
            {
                Console.WriteLine(stringArray[string1]);
            }
            else
            {
                Console.WriteLine("Your number was too high. Pick a number between 1 and 4.");
            }

            // prompt two
            int[] numArray = new int[] {1,3,5,7,10};
            Console.WriteLine("There is an array of integers built.  Choose a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 <= 4 && number1 >= 0)
            {
                Console.WriteLine(numArray[number1]);
            }
            else
            {
                Console.WriteLine("Your number was too high. Pick a number between 1 and 4.");
            }

            // prompt 3
            List<string> stringList = new List<string>();
            stringList.Add("Pickles");
            stringList.Add("Onions");
            Console.WriteLine("There's a list of 2 items. Pick 0 or 1.");
            int list1 = Convert.ToInt32(Console.ReadLine());
            if (list1 >= 0 && list1 <= 1)
            {
                Console.WriteLine(stringList[list1]);
            }
            else
            {
                Console.WriteLine("Your number was outside of the range, sorry.");
            }
            
            Console.Read();
        }
    }
}
