using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace ChickenMicken
{
    /// <summary>
    /// Interface where we initialize the Drawing Methods on the screen
    /// </summary>
    interface IGameStats
    {
        // Drawing Player lives
        void DrawLives(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);

        // Drawing Player Score
        void DrawScore(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);

        // Drawing Player Level
        void DrawLevel(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y);
    }
}
