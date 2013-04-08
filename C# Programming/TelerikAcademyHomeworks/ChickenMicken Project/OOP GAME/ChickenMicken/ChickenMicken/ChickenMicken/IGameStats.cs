using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace ChickenMicken
{
    interface IGameStats
    {
        void DrawLives(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);
        void DrawScore(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);
        void DrawLevel(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);
    }
}
