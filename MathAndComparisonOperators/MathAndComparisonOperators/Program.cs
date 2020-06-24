using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.Write(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Please enter a number:");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            int total = inputValue * 50;
            Console.WriteLine(total);
            Console.WriteLine("Please enter a number:");
            int inputValue2 = Convert.ToInt32(Console.ReadLine());
            int total2 = inputValue2 + 25;
            Console.WriteLine(total2);
            Console.WriteLine("Please enter a number:");
            int inputValue3 = Convert.ToInt32(Console.ReadLine());
            double total3 = inputValue3 / 12.5;
            Console.WriteLine(total3);
            Console.WriteLine("Please enter a number:");
            int inputValue4 = Convert.ToInt32(Console.ReadLine());
            int total4 = inputValue4 % 7;
            Console.WriteLine(total4);
            Console.ReadLine();


        }
    }
}
