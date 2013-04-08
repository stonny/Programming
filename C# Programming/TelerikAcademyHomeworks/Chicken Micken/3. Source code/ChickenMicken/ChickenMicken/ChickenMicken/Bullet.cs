using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ChickenMicken
{
    /// <summary>
    /// This class target is to create enemy bullets with set frequency
    /// </summary>
   class Bullet
    {
        // producing buletts
        public static void BulletGeneratorAttack(GameTime gameTime, List<Enemy> chickens, ContentManager Content, List<EnemyAttack> bullets)
        {
            foreach (var chicken in chickens)
            {
                if (chicken.Interval > 1)
                {
                    chicken.Interval = 0;

                    // If there are less than 3 bullets on the screen -> make another bullet
                    if (bullets.Count < 3)
                    {
                        // Generate a new bullet with position of the current chicken plus his speed
                        EnemyAttack bullet = new EnemyAttack(Content.Load<Texture2D>("Images\\ChickenPoo"),
                            new Vector2(chicken.Postion.X +25, chicken.Postion.Y + 45), chicken.SpeedY);
                        bullets.Add(bullet);
                        // The chicken texture changes during each shot
                        chicken.Texture = Content.Load<Texture2D>("Images\\Chicken");
                    }
                }
            }
        }
        public static void BulletUpdate(List<EnemyAttack> bullets)
        {
            // Updates the position for each bullet
            foreach (var bullet in bullets)
            {
                bullet.Update();
            }
            // Removes bullet when they leave the screen
            for (int index = 0; index < bullets.Count; index++)
            {
                if (bullets[index].Position.Y + bullets[index].Texture.Height >= 730)
                {
                    bullets.RemoveAt(index);
                    index--;
                }
            }
        }
        //drawing the bullets
        public static void DrawBullet(List<EnemyAttack> bullets, SpriteBatch spriteBatch, SpriteFont font)
        {
            foreach (var bullet in bullets)
            {
                bullet.Draw(spriteBatch);
            }
        }
    }  
}
