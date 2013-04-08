using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ChickenMicken
{
    public class MouseMoves
    {
        /// <summary>
        /// This is the MouseMoves class in witch we create a hover efect of the mouse
        /// and create the main logic when the left button is pressed
        /// </summary>
         
        protected Vector2 Size { get; set; }
        protected Vector2 PositionB { get; set; }
        protected Rectangle FormButton { get; set; }
        bool Down { get; set; }
        public bool IsClicked { get; set; }
        protected Color colorButton = new Color(255, 255, 255, 255);
        //mouse update
        //changing the menu with the mouse
        public void Update(MouseState mouse)
        {
            FormButton = new Rectangle((int)PositionB.X, (int)PositionB.Y, (int)Size.X, (int)Size.Y);
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);
            // hover efect of the button
            if (mouseRect.Intersects(this.FormButton))
            {
                if (colorButton.A == 255)
                {
                    Down = false;
                }
                if (colorButton.A == 0)
                {
                    Down = true;
                }
                if (Down == true)
                {
                    colorButton.A += 3;
                }
                else
                {
                    colorButton.A -= 3;
                }
                // check if the left mouse button is pressed
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    IsClicked = true;
                }
            }
            else if (colorButton.A < 255)
            {
                colorButton.A += 3;
                IsClicked = false;
            }
        }
        //button logic for changing the state throw the mouse
        public void CallButtonLogic(GameState currentGameState, MouseState mouse)
        {
            if (currentGameState == GameState.MainMenu)
            {
                Update(mouse);
                if (IsClicked == true)
                {
                    GameStateLogic.currentGameState = GameState.Playing;
                }
            }
        }
    }
}
