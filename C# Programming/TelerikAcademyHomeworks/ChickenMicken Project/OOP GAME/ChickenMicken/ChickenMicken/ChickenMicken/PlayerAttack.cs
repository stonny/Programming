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
    class PlayerAttack : GameObject
    {
        // Hard coded Fields as they won't be changed
        private  float rotation = 0;
        private  float rotationSpeed = 0.5f;
        private const int ATTACK_SPEED = 10;

        // Constructor that sets the form and the position from where the attacks will start
        public PlayerAttack(Texture2D texture, Vector2 vector)
        {
            this.texture = texture;
            this.position = vector;
            this.originCoord.X = texture.Width / 2;
            this.originCoord.Y = texture.Height / 2;
        }

        // Property to determine the vertical position as the player will shoot vertically
        new public Vector2 Position
        {
            get { return this.position; }
        }

        // Overrided Update Method - setting the position of the shots
        public override void Update()
        {
            this.form = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            rotation += rotationSpeed;
            this.position.Y -= ATTACK_SPEED;
        }

        // Overrided Drawable method - drawin the shots
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, rotation, originCoord, 1f, SpriteEffects.None, 0f);
        }
    }
}
