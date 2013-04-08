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
        private float interval;
        private GameTime gameTime;
        // Random X coordinate
        private int RandomSpeedX { get; set; }
        // Rabdom Y coordinate
        private int RandomSpeedY { get; set; }
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
            get { return this.interval; }
            set { this.interval = value; }
        }

        public Enemy(Texture2D texture, Rectangle form, Vector2 position, GameTime gameTime)
        {
            this.Texture = texture;
            this.position = position;
            this.gameTime = gameTime;
            this.form = form;

            // random speed for the chickens
            RandomSpeedX = NumberOfEnemy.Generate(-2, 2);
            RandomSpeedY = NumberOfEnemy.Generate(1, 4);
            base.Speed = new Vector2(RandomSpeedX, RandomSpeedY);
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
                base.speed.X *= -1;
            }
            Interval += (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
