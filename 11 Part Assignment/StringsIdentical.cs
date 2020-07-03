using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsIdentical
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drinks = new List<string>() { "coffee", "espresso", "mocha", "latte", "coffee" };
            Console.WriteLine("Please enter coffee, espresso, mocha, or latte:");
            string favoriteDrink = Console.ReadLine();

            foreach (string drink in drinks)
            {
                if (drink == favoriteDrink)
                {
                    Console.WriteLine(drinks.IndexOf(favoriteDrink));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That type of drink is not listed.");
                    Console.ReadLine();
                }

            }
            
        }
        
    }
}
