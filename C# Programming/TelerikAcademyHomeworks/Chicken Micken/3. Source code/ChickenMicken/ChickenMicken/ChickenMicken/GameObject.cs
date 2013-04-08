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
        // Initializing the fields that we will be using
        protected Texture2D texture;
        protected Vector2 position;
        protected Vector2 speed;
        protected Vector2 originCoord;
        protected Color color = new Color(255,255,255,255);
        protected Rectangle form;

        // Virtual Update Method that will be overrided for each of GameObject's child classes
        public virtual void Update()
        {
        }

        // Virtual Method of the Game Object class which is used to Draw for each object
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.form, Color.White);
        }

        // Property that will set the Rectangle Form - that will be our hitbox
        protected Rectangle Form
        {
            get { return this.form; }
            set { this.form = value; }
        }

        // Setting the image that we will be using as Texture
        public Texture2D Texture
        {
            get { return this.texture; }
            set { this.texture = value; }
        }

        // Setting the position of the object
        protected Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        // Setting the speed of the object
        protected Vector2 Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        
        // Setting the original Coordinates
        protected Vector2 OriginCoord
        {
            get { return this.originCoord; }
            set { this.originCoord = value; }
        }
    }
}
