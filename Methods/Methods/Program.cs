using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();
            int variableTriple = math.tripleNumber(userNum);
            int variableQuadruple = math.quadrupleNumber(userNum);
            int variableSquare = math.squareNumber(userNum);

            Console.WriteLine("Triple of that number is " + variableTriple);
            Console.WriteLine("Quadruple of that number is " + variableQuadruple);
            Console.WriteLine("The square of that number is " + variableSquare);
            Console.ReadLine();
        }
    }
}
