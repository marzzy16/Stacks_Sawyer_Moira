using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Sawyer_Moira
{
   
     class Card
    {
        // string data type Number.
        public string Number { get; }
        // string data type Suit.
        public string Suit { get; }
        // Assigns number to Number and suite to Suit.
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
