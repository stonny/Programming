using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ChickenMicken
{
    public class GameStats : IGameStats
    {
        void IGameStats.DrawLives(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Lives:" + spaceShip.PlayerHealth, new Vector2(x, y), Color.White);
        }

        void IGameStats.DrawScore(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Score:" + spaceShip.PlayerScore, new Vector2(x, y), Color.White);
        }

        void IGameStats.DrawLevel(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Level:" + spaceShip.PlayerLevel, new Vector2(x, y), Color.White);
        }
    }
}
