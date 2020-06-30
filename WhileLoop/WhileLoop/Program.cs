using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 4:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 4;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Try Again.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Try Again.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Try Again.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You are correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Try Again.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}
