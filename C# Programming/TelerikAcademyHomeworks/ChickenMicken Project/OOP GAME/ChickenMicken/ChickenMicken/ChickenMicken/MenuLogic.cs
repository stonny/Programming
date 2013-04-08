using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ChickenMicken
{
    public class MenuLogic 
    {
        public MouseState mouse;
        public Vector2 size;
        public Texture2D textureButton;
        public Vector2 positionB;
        public Color colorButton = new Color(255, 255, 255, 255);
        public Rectangle formButton;
        bool down;
        public bool isClicked;
        //mouse update
        public void Update(MouseState mouse)
        {
            formButton = new Rectangle((int)positionB.X, (int)positionB.Y, (int)size.X, (int)size.Y);
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);
            if (mouseRect.Intersects(this.formButton))
            {
                if (colorButton.A == 255)
                {
                    down = false;
                }
                if (colorButton.A == 0)
                {
                    down = true;
                }
                if (down == true)
                {
                    colorButton.A += 3;
                }
                else
                {
                    colorButton.A -= 3;
                }
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;
                }
            }
            else if (colorButton.A < 255)
            {
                colorButton.A += 3;
                isClicked = false;
            }
        }
       
    }
}
