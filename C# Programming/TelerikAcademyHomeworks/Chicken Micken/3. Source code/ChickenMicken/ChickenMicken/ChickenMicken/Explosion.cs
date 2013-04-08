using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;
 
namespace ChickenMicken
{
    /// <summary>
    /// Main target of the class is to create an Explosion(For chickens "Pool of blood")
    /// and to add a fading effect
    /// </summary>
    public class Explosion : GameObject
    {
        private int fade = 250;
        private const int RATE = 3;
        private const float SPEED = 0.5f;

        // Constructor to set the values to the fields
        public Explosion(Texture2D texture, Vector2 position, Vector2 speed)
        {
            base.texture = texture;
            base.Position = position;
            base.speed  = speed;
        }
        
        // Getting the new Position
        new public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        // Getting the new Texture
        new public Texture2D Texture
        {
            get { return this.texture; }
        }

        // Overrided update Method
        public override void Update()
        {
            fade -= RATE;
            position.Y += speed.Y - SPEED;

            // This is used to fade the explosion
            base.color = new Color(fade, fade, fade, fade);
        }

        // Overrided Draw Method
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, color);
        }

    }
}
