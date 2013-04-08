using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ChickenMicken
{
    /// <summary>
    /// The Class main target is to draw the background of the Play Field
    /// It can be used further to draw other things
    /// </summary>
   public class BackgroundPicture : GameObject
    {
       // Constructor that sets the texture, size of the texture and the color (color can be used for transperancy)
        public BackgroundPicture(Texture2D texture, Rectangle form, Color color)
        {
            base.texture = texture;
            base.form = form;
            base.color = color;
        }

        // Overrided Drawable Method 
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.form, color);
        }

        // Empty Update Method, as it won't do anything different than the inherited class
        public override void Update()
        {

        }

        // Setting the Position of the Background picture
        private int PositionX
        {
            get { return this.form.X; }
            set { this.form.X = value; }
        }
    }
}
