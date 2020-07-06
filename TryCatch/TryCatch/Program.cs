using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(98);
                numbers.Add(99);
                numbers.Add(88);
                numbers.Add(72);
                numbers.Add(70);

                Console.WriteLine("Enter a number:");
                int divider = Convert.ToInt32(Console.ReadLine());

                foreach(int number in numbers)
                {
                    if(number >= 70)
                    {
                        int solution = number / divider;
                        Console.WriteLine(solution);
                    }
                }



            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don’t divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }


        }
        }
}
