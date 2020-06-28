using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number between 1 and 4:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 4;
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number between 1 and 4:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You are correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.Write("You are wrong.");
                        Console.Write("Guess a number between 1 and 4:");
                        break;

                }
            }
            while (!isGuessed);
        }
    }
}
