using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Math
    {
        public int triple;
        public int quadruple;
        public int square;

        public int tripleNumber(int userNum)
        {
            triple = 3 * userNum;
            return triple;
        }

        public int quadrupleNumber(int userNum)
        {
            quadruple = 4 * userNum;
            return quadruple;
        }

        public int squareNumber(int userNum)
        {
            square = userNum * userNum;
            return square;
        }
        
    }
}
