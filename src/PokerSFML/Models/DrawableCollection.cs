using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerSFML.Models
{
    class DrawableCollection : Drawable
    {
        private List<Drawable> _sprites;
        public DrawableCollection()
        {
            _sprites = new List<Drawable>();
        }

        public void AddItem(Drawable item)
        {
            _sprites.Add(item);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            foreach (var item in _sprites)
            {
                target.Draw(item);
            }
        }
    }
}
