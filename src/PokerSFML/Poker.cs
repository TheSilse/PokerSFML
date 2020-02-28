using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerSFML
{
    class Poker
    {
        static public RenderWindow Window;
        public void Game()
        {
            Window = new RenderWindow(new VideoMode(800,600), "Poker");
            Window.SetVerticalSyncEnabled(true);
            Window.Closed += Window_Closed;
            while (Window.IsOpen)
            {
                Window.DispatchEvents();

                Window.Clear(Color.Green);

                Window.Display();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window.Close();
        }
    }
}
