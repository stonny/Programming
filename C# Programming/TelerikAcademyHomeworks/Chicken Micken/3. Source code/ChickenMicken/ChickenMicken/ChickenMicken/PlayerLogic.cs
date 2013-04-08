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
    /// This class target is to define the Main Player Logic - Adding, Updating and Drawing shots
    /// </summary>
    class PlayerLogic
    {
        // Method that allows attack to be initialized only after Releasing the Space button
        public static void SpaceShipAttacksAdd(ContentManager Content, Player spaceShip, List<PlayerAttack> spaceShipAttacks,
          KeyboardState presentKey, KeyboardState pastKey)
        {
            if (presentKey.IsKeyDown(Keys.Space) && pastKey.IsKeyUp(Keys.Space))
            {

                spaceShipAttacks.Add(new PlayerAttack(Content.Load<Texture2D>("Images\\hatchet"), new Vector2(spaceShip.PositionX + 25, spaceShip.PositionY)));

            }
        }

        // Update Method that updates the position of the attacks
        public static void AttackUpdate(GraphicsDevice graphics, Player spaceShip, List<PlayerAttack> spaceShipAttacks,
           KeyboardState presentKey, KeyboardState pastKey)
        {
            foreach (var attack in spaceShipAttacks)
            {
                attack.Update();
            }

            for (int index = 0; index < spaceShipAttacks.Count; index++)
            {
                if (spaceShipAttacks[index].Position.X > graphics.Viewport.Width +
                    spaceShipAttacks[index].Texture.Width)
                {
                    // if the attack is off screen it will be removed from the list
                    spaceShipAttacks.RemoveAt(index);
                    index--;
                }
            }
        }

        // Method that Draws the new attacks
        public static void DrawAttacks(List<PlayerAttack> spaceShipAttacks, SpriteBatch spriteBatch, SpriteFont font)
        {
            foreach (var attack in spaceShipAttacks)
            {
                attack.Draw(spriteBatch);
            }
        }
    }
}

