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
    public class Enemy : GameObject
    {
        private int randomSpeedX;    // Random X coordinate
        private int randomSpeedY;    // Rabdom Y coordinate
        private float hatchetInterval; // Used to set attack interval
        private float coolDown = 0;     // Used for animation interval
        private GameTime gameTime;

        public Vector2 Postion
        {
            get { return this.position; }
        }

        public int SpeedY
        {
            get
            {
                return (int)this.
                    Speed.Y;
            }
        }

        public float Interval
        {
            get { return this.hatchetInterval; }
            set { this.hatchetInterval = value; }
        }

        public float CoolDown
        {
            get { return this.coolDown; }
            set { this.coolDown = value; }
        }
        public Enemy(Texture2D texture, Rectangle form, Vector2 position, GameTime gameTime)
        {
            this.Texture = texture;
            this.position = position;
            this.gameTime = gameTime;
            this.form = form;

            // random speed for the chickens
            randomSpeedX = NumberOfEnemy.Generate(-2, 2);
            randomSpeedY = NumberOfEnemy.Generate(1, 4);
            base.Speed = new Vector2(randomSpeedX, randomSpeedY);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, new Rectangle((int)(this.position.X),(int)(this.position.Y), 70, 70) , Color.White);
        }
        public void Update(GraphicsDevice graphics)
        {
            this.Position += this.Speed;
            if (this.Position.X <= 0 || this.Position.X + this.Texture.Width >= 1100)
            {
                this.speed.X = -this.speed.X;
            }
            hatchetInterval += (float)gameTime.ElapsedGameTime.TotalSeconds;
            coolDown += (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
