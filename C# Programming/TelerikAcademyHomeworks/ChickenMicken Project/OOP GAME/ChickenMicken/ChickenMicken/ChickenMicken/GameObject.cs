using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChickenMicken
{
    /// <summary>
    /// This is the main GameObject class of the game in which Size of the object are set and are being drawn
    /// </summary>
    public abstract class GameObject
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Vector2 speed;
        protected Vector2 originCoord;
        public Color color = new Color(255,255,255,255);
        protected Rectangle form;
        public virtual void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.form, Color.White);
        }
        // properties
        protected Rectangle Form
        {
            get { return this.form; }
            set { this.form = value; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
            set { this.texture = value; }
        }

        protected Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        protected Vector2 Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        protected Vector2 OriginCoord
        {
            get { return this.originCoord; }
            set { this.originCoord = value; }
        }
    }
}
