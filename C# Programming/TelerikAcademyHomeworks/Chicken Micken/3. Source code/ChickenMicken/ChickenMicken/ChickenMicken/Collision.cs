using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace ChickenMicken
{
    public class Collision : ICollidiable
    {
        // Method that checks if the Player attacks have hit the enemy
        void ICollidiable.CollisionPlayerAttacksToEnemy(ContentManager Content, List<PlayerAttack> spaceShipAttacks, List<Enemy> chickens, List<Explosion> explosions, Player spaceShip)
        {
            for (int playerIndex = 0; playerIndex < spaceShipAttacks.Count; playerIndex++)
            {
                // Creating the hit box  of the Player's attack (hatchet) as Rectangle
                Rectangle spaceShipAttactkSize = new Rectangle((int)spaceShipAttacks[playerIndex].Position.X - 100,
                    (int)spaceShipAttacks[playerIndex].Position.Y, spaceShipAttacks[playerIndex].Texture.Width / 2,
                    spaceShipAttacks[playerIndex].Texture.Height / 2);

                for (int enemyIndex = 0; enemyIndex < chickens.Count; enemyIndex++)
                {
                    // Creating the hit box of the Chicken as Rectangle
                    Rectangle chicken = new Rectangle((int)chickens[enemyIndex].Postion.X - 100,
                        (int)(chickens[enemyIndex].Postion.Y), chickens[enemyIndex].Texture.Width / 2 - 110,
                        chickens[enemyIndex].Texture.Height / 2 - 74);

                    // If the hit boxes interesect
                    if (spaceShipAttactkSize.Intersects(chicken))
                    {
                        // Generate a new explosions on the current position
                        explosions.Add(new Explosion(Content.Load<Texture2D>("Images\\ChickenDead"), new Vector2(chickens[enemyIndex].Postion.X,
                            chickens[enemyIndex].Postion.Y), new Vector2(0,0)));
                        // Adding score to the player
                        
                        // Remove the player attacks that hit the target enemy
                        spaceShipAttacks.RemoveAt(playerIndex);
                        spaceShip.PlayerScore += 15;

                        // Remove the enemy that was hit
                        chickens.RemoveAt(enemyIndex);
                        playerIndex--;
                        enemyIndex--;
                        break;
                    }
                }
            }
        }

        // Method that checks if Player have hit the Enemy
        void ICollidiable.CollisionPlayerToEnemy(ContentManager Content, Player spaceShip, List<Enemy> chickens, List<Explosion> explosions)
        {
            for (int playerIndex = 0; playerIndex < chickens.Count; playerIndex++)
            {

                // Creating the hit box  of the Player (spaceship) as Rectangle
                Rectangle spaceShipRectangle = new Rectangle((int)spaceShip.PositionX, (int)spaceShip.PositionY, spaceShip.Texture.Width - 348, spaceShip.Texture.Height - 255);

                for (int enemyIndex = 0; enemyIndex < chickens.Count; enemyIndex++)
                {
                    // Creating the hitbox of the Chicken as Rectangle
                    // Some hardcoded values for the coordinates as the image isn't resized (To be fixed)
                    Rectangle chicken = new Rectangle((int)chickens[enemyIndex].Postion.X,(int)(chickens[enemyIndex].Postion.Y), chickens[enemyIndex].Texture.Width / 2 - 110,
                            chickens[enemyIndex].Texture.Height / 2 - 74);

                    // Check if the two hitbox Intersect
                    if (spaceShipRectangle.Intersects(chicken))
                    {
                        // Generate a new explosions on the current position
                        explosions.Add(new Explosion(Content.Load<Texture2D>("Images\\SpaceShipDead"), new Vector2(chickens[enemyIndex].Postion.X,
                            chickens[enemyIndex].Postion.Y), new Vector2(0, 0)));

                        // Remove player health as he colides with the enemy
                        spaceShip.PlayerLives--;
                      
                        // Remove the enemy it has hit 
                        chickens.RemoveAt(enemyIndex);
                        playerIndex--;
                        enemyIndex--;
                        break;
                    }
                }
            }
        }

        // Method that checks if the Attacks of the Enemy have hit the Player (spaceship)
        void ICollidiable.CollisionEnemychickenAttacksToPlayer(ContentManager Content, Player spaceShip, List<EnemyAttack> chickenAttacks, List<Explosion> explosions)
        {
            // Create hit box of the SpaceShip as Rectangle with hardcoded values because the image isnt resized (To be fixed )
            Rectangle spaceShipRectangle = new Rectangle((int)spaceShip.PositionX, (int)spaceShip.PositionY, spaceShip.Texture.Width - 348, spaceShip.Texture.Height - 255);

            for (int index = 0; index < chickenAttacks.Count; index++)
            {
                // Creating hit box of the Hatchet as a rectangle
                Rectangle hatchet = new Rectangle((int)chickenAttacks[index].Position.X,
                    (int)(chickenAttacks[index].Position.Y), chickenAttacks[index].Texture.Width,
                    chickenAttacks[index].Texture.Height);

                // Check if the boxes Intersect
                if (spaceShipRectangle.Intersects(hatchet))
                {
                    // Remove player health as he has been hit
                    spaceShip.PlayerLives--;

                    // Generate a new explosions on the current position
                    explosions.Add(new Explosion(Content.Load<Texture2D>("Images\\boom"), new Vector2(spaceShip.PositionX,
                        spaceShip.PositionY), new Vector2(0, 0)));

                    // Remove the chicken attack as it has already hit the Player
                    chickenAttacks.RemoveAt(index);
                    index--;
                }
            }
        }

       
    }
}
