using PokerSFML.Enums;
using SFML.Graphics;
using System.Collections.Generic;

namespace PokerSFML.Services
{
    class SpriteManager
    {
        public static Dictionary<Suits, Dictionary<Ranks, Sprite>> Sprites { get; set; }
        public static Sprite Background { get; set; }
        public static Sprite Shirt { get; set; }

        public static void Init()
        {
            Sprites = new Dictionary<Suits, Dictionary<Ranks, Sprite>>
            {
                {Suits.Diamond, new Dictionary<Ranks, Sprite>
                    {
                        {Ranks.Two, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/2.png")) },
                        {Ranks.Three, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/3.png")) },
                        {Ranks.Four, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/4.png")) },
                        {Ranks.Five, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/5.png")) },
                        {Ranks.Six, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/6.png")) },
                        {Ranks.Seven, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/7.png")) },
                        {Ranks.Eight, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/8.png")) },
                        {Ranks.Nine, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/9.png")) },
                        {Ranks.Ten, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/10.png")) },
                        {Ranks.Jack, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/Jack.png")) },
                        {Ranks.Queen, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/Queen.png")) },
                        {Ranks.King, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/King.png")) },
                        {Ranks.Ace, new Sprite(new Texture("Assets/Sprites/Cards/Diamonds/Ace.png")) },
                    }
                },
                  {Suits.Club, new Dictionary<Ranks, Sprite>
                    {
                        {Ranks.Two, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/2.png")) },
                        {Ranks.Three, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/3.png")) },
                        {Ranks.Four, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/4.png")) },
                        {Ranks.Five, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/5.png")) },
                        {Ranks.Six, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/6.png")) },
                        {Ranks.Seven, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/7.png")) },
                        {Ranks.Eight, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/8.png")) },
                        {Ranks.Nine, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/9.png")) },
                        {Ranks.Ten, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/10.png")) },
                        {Ranks.Jack, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/Jack.png")) },
                        {Ranks.Queen, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/Queen.png")) },
                        {Ranks.King, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/King.png")) },
                        {Ranks.Ace, new Sprite(new Texture("Assets/Sprites/Cards/Clubs/Ace.png")) },
                    }
                },
                   {Suits.Heart, new Dictionary<Ranks, Sprite>
                    {
                        {Ranks.Two, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/2.png")) },
                        {Ranks.Three, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/3.png")) },
                        {Ranks.Four, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/4.png")) },
                        {Ranks.Five, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/5.png")) },
                        {Ranks.Six, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/6.png")) },
                        {Ranks.Seven, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/7.png")) },
                        {Ranks.Eight, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/8.png")) },
                        {Ranks.Nine, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/9.png")) },
                        {Ranks.Ten, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/10.png")) },
                        {Ranks.Jack, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/Jack.png")) },
                        {Ranks.Queen, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/Queen.png")) },
                        {Ranks.King, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/King.png")) },
                        {Ranks.Ace, new Sprite(new Texture("Assets/Sprites/Cards/Hearts/Ace.png")) },
                    }
                },
                    {Suits.Spade, new Dictionary<Ranks, Sprite>
                    {
                        {Ranks.Two, new Sprite(new Texture("Assets/Sprites/Cards/Spades/2.png")) },
                        {Ranks.Three, new Sprite(new Texture("Assets/Sprites/Cards/Spades/3.png")) },
                        {Ranks.Four, new Sprite(new Texture("Assets/Sprites/Cards/Spades/4.png")) },
                        {Ranks.Five, new Sprite(new Texture("Assets/Sprites/Cards/Spades/5.png")) },
                        {Ranks.Six, new Sprite(new Texture("Assets/Sprites/Cards/Spades/6.png")) },
                        {Ranks.Seven, new Sprite(new Texture("Assets/Sprites/Cards/Spades/7.png")) },
                        {Ranks.Eight, new Sprite(new Texture("Assets/Sprites/Cards/Spades/8.png")) },
                        {Ranks.Nine, new Sprite(new Texture("Assets/Sprites/Cards/Spades/9.png")) },
                        {Ranks.Ten, new Sprite(new Texture("Assets/Sprites/Cards/Spades/10.png")) },
                        {Ranks.Jack, new Sprite(new Texture("Assets/Sprites/Cards/Spades/Jack.png")) },
                        {Ranks.Queen, new Sprite(new Texture("Assets/Sprites/Cards/Spades/Queen.png")) },
                        {Ranks.King, new Sprite(new Texture("Assets/Sprites/Cards/Spades/King.png")) },
                        {Ranks.Ace, new Sprite(new Texture("Assets/Sprites/Cards/Spades/Ace.png")) },
                    }
                },

            };
            Shirt = new Sprite(new Texture("Assets/Sprites/Cards/Shirt.png"));
            Background = new Sprite(new Texture("Assets/Sprites/Table.png"));
        }
    }
}


