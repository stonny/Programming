using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;
 
namespace ChickenMicken
{
    class Explosion : GameObject
    {
        private int fade = 250;
        private const int RATE = 3;
        private const float SPEED = 0.5f;
        private Color color;

        public Explosion(Texture2D texture, Vector2 position, Vector2 speed)
        {
            this.texture = texture;
            this.position = position;
            this.speed  = speed;
        }

        public Vector2 Position
        {
            get { return this.position; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
        }

        public override void Update()
        {
            fade -= RATE;
            position.Y += speed.Y - SPEED;

            // Although color requires 255 as a max value, 355 will give 
            // us some buffer before the fading takes effect.
            // It will be automaticaly replaced with the largest value possible.
            this.color = new Color(fade, fade, fade, fade);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, color);
        }

    }
}
