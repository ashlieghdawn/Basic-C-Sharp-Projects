using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(62);
            testScores.Add(60);
            testScores.Add(50);

            foreach (int score in testScores)
            {
                if (score <= 62)
                {
                    Console.WriteLine("Failing test score: " + score);
                }
            }
            Console.ReadLine();


        }
    }
}
