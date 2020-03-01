using PokerSFML.Services;
using System.Threading.Tasks;

namespace PokerSFML
{
    class Program
    {
        static void Main(string[] args)
        {
            SpriteManager.Init();
            StartAsync().GetAwaiter().GetResult();
        }
        public static async Task StartAsync()
        {
            Window window = new Window(800, 600);
            Poker poker = new Poker();
            Task.Run(() => poker.StartAsync());

            await window.RunAsync();
        }
    }
}
