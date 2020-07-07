using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }  //making this property public makes it accessible to other parts of the program
        public string Face { get; set; }
    }
}
