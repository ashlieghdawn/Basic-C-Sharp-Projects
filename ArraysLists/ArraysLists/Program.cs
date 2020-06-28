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
            int[] numArray = new int[] {1,3,5,7,10};
            Console.WriteLine("There is an array of integers built.  Choose a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 <= 5)
            {
                Console.WriteLine(numArray[number1]);
                string[] stringArray = new string[] { "coffee", "bean", "caffeine", "sprouts" };
                Console.WriteLine("There is an array of strings, pick a number to print one:");
                int string1 = Convert.ToInt32(Console.ReadLine());
                if (string1 <= 4)
                {
                    Console.WriteLine(stringArray[string1]);
                    List<string> stringList = new List<string>();
                    stringList.Add("Pickles");
                    stringList.Add("Onions");
                    Console.WriteLine("There's a list of 2 items. Pick 0 or 1.");
                    int list1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stringList[list1]);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Your number was too high. Pick a number between 1 and 4.");
                    int string2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stringArray[string2]);
                }
            }
            else
            {
                Console.WriteLine("Your number was too high. Pick a number between 1 and 4.");
            }
            Console.Read();
        }
    }
}
