using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace ChickenMicken
{
    public class ExplosionLogic
    {
        // Method that Updates the Explosion
        public static void ExplosionUpdate(List<Explosion> explosions)
        {
            foreach (var explosion in explosions)
            {
                explosion.Update();
            }

            for (int index = 0; index < explosions.Count; index++)
            {
                if (explosions[index].Position.X + explosions[index].Texture.Width <= 0)
                {
                    explosions.RemoveAt(index);
                    index--;
                }
            }
        }

        // Method that draws the explosions
        public static void DrawExplosions(List<Explosion> explosions, SpriteBatch spriteBatch)
        {
            foreach (var explosion in explosions)
            {
                explosion.Draw(spriteBatch);
            }
        }
    }

    public class CopyOfExplosionLogic
    {
        // Method that Updates the Explosion
        public static void ExplosionUpdate(List<Explosion> explosions)
        {
            foreach (var explosion in explosions)
            {
                explosion.Update();
            }

            for (int index = 0; index < explosions.Count; index++)
            {
                if (explosions[index].Position.X + explosions[index].Texture.Width <= 0)
                {
                    explosions.RemoveAt(index);
                    index--;
                }
            }
        }

        // Method that draws the explosions
        public static void DrawExplosions(List<Explosion> explosions, SpriteBatch spriteBatch)
        {
            foreach (var explosion in explosions)
            {
                explosion.Draw(spriteBatch);
            }
        }
    }
}
