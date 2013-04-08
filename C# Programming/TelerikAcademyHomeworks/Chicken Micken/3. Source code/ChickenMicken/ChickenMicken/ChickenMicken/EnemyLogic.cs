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
    class EnemyLogic 
    {
        public static float enemyInterval = 1;
        public static float enemyIntervalSeconds = 1;
        public static int chickenNumber = 5;


        public static void ChickenGenerator(GameTime gameTime, List<Enemy> chickens, ContentManager Content)
        {
            //interval for enemy spawning
            enemyInterval += (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Adds enemies
            if (enemyInterval >= enemyIntervalSeconds)
            {
                enemyInterval = 0;  // reset the counter
                if (chickens.Count < chickenNumber)
                {
                    chickens.Add(new Enemy(Content.Load<Texture2D>("Images\\Chicken"),new Rectangle(350,600,50,50),
                        new Vector2(NumberOfEnemy.Generate(0, 620), -70), gameTime));
                }              
            }          
        }
        public static void ChickenRemove(GraphicsDevice graphics, List<Enemy> chickens)
        {
            // Updates the position for each chicken
            foreach (var chicken in chickens)
            {
                chicken.Update(graphics);
            }

            // Removes chicken when they leave the screen
            for (int index = 0; index < chickens.Count; index++)
            {
                if (chickens[index].Postion.Y + chickens[index].Texture.Height >= 970)
                {
                    chickens.RemoveAt(index);
                    index--;
                }
            }
        } 
    }
}
