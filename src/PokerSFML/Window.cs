using PokerSFML.Models;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;
using System.Threading.Tasks;

namespace PokerSFML
{
    public class Window
    {

        public uint Height { get; set; }
        public uint Width { get; set; }
        private RenderWindow _win { get; set; }

        private DrawableCollection _drawableCollection;
        public Window(uint height, uint width)
        {
            Height = height;
            Width = width;
            _win = new RenderWindow(new VideoMode(Height, Width), "Poker");
            _drawableCollection = new DrawableCollection();
        }
        
        public async Task RunAsync()
        {
            _win.SetVerticalSyncEnabled(true);
            _win.Closed += Window_Closed;
            while (_win.IsOpen)
            {
                _win.DispatchEvents();
                _win.Clear(Color.White);
                _win.Draw(_drawableCollection);
                _win.Display();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _win.Close();
        }
    }
}
