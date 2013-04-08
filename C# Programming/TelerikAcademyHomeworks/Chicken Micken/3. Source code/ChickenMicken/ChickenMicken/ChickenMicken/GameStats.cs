using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ChickenMicken
{
    /// <summary>
    /// In this class is implemented the methods of the IGameStats
    /// </summary>
    public class GameStats : IGameStats
    {

        // Drawing the Player Lives on the screen
        void IGameStats.DrawLives(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Lives:" + spaceShip.PlayerLives, new Vector2(x, y), Color.White);
        }

        // Drawing the PLayer Score on the screen
        void IGameStats.DrawScore(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Score:" + spaceShip.PlayerScore, new Vector2(x, y), Color.White);
        }

        // Drawing the Player Level on the screen
        void IGameStats.DrawLevel(Player spaceShip, SpriteBatch spriteBatch, SpriteFont font, int x, int y)
        {
            spriteBatch.DrawString(font, "Level:" + spaceShip.PlayerLevel, new Vector2(x, y), Color.White);
        }
    }
}
