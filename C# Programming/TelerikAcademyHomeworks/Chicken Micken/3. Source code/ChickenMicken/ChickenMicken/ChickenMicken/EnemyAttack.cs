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
    public class EnemyAttack : GameObject
    {
        /// <summary>
        /// This class target is to define the Enemy Logic for Attack.Drawing and updating it.
        /// </summary>
        // The speed of the bullet
        private float speedBullets { get; set; }  
        public EnemyAttack(Texture2D texture, Vector2 position, float speed, float speedBullets = 2f)
        {
            this.texture = texture;
            this.position = position;
            this.speedBullets = speedBullets;
            this.position = position;
            // The speed of the enemy plus the speed of the bullet
            this.speed.Y = speed + speedBullets; 
        }

        public  new Vector2  Position
        {
            get { return this.position; }
        }

        public int SpeedY
        {
            get { return (int)this.Speed.Y; }
        }

        public override void Update()
        {
            this.position.Y += this.Speed.Y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.position, Color.White);
        }
    }
}
