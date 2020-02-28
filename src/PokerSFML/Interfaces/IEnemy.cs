using System;
using System.Collections.Generic;
using System.Text;

namespace PokerSFML
{
    interface IEnemy
    {

        static int Chips;
        static int Bet;
        void CardHand();
        void Call();
        void Check();
        void Fold();
        
    }
}
