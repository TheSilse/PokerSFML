using PokerSFML.Services;

namespace PokerSFML
{
    class Program
    {
        static void Main(string[] args)
        {
            SpriteManager.Init();
            Poker game = new Poker();
            game.Run();
        }
    }
}
