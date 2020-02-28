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
