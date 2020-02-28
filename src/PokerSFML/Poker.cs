using PokerSFML.Services;
using SFML.Graphics;
using SFML.Window;
using System;

namespace PokerSFML
{
    class Poker
    {
        public RenderWindow Window { get; set; }
        public uint Height { get; set; }
        public uint Width { get; set; }
        public void Run()
        {
            Height = 1366;
            Width = 768;
            Window = new RenderWindow(new VideoMode(Height, Width), "Poker");
            Window.SetVerticalSyncEnabled(true);
            Window.Closed += Window_Closed;
            while (Window.IsOpen)
            {
                Window.DispatchEvents();
                Window.Clear(Color.Green);
                Window.Draw(SpriteManager.Shirt);
                Window.Display();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
