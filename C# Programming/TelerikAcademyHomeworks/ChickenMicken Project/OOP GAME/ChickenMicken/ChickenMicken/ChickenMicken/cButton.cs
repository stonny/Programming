using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace ChickenMicken
{
    public class cButton : MenuLogic
    {
       
        public cButton(Texture2D newTexture,GraphicsDevice graphics)
        {
            base.textureButton = newTexture;
            base.size = new Vector2(graphics.Viewport.Width / 8, graphics.Viewport.Height / 8);
        }
        //set the position of the button
        public void SetPositionOfButton(Vector2 newPosition)
        {
            base.positionB = newPosition;
        }
        //draw the button
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(textureButton, formButton, colorButton);
        }
        public void DrawButton(GameState currentGamestate, SpriteBatch spriteBatch, ContentManager Content, int WindowWidth, int WindowHeight)
        {
            switch (currentGamestate)
            {
                case GameState.MainMenu:
                    spriteBatch.Draw(Content.Load<Texture2D>("Images\\BackgroundMainMenu"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);
                    Draw(spriteBatch);
                    break;
            }
        }
        public void CallButtonLogic(GameState currentGameState,MouseState mouse)
        {
            switch (currentGameState)
            {
                case GameState.MainMenu:
                   
                    Update(mouse);
                    if (isClicked == true)
                    {
                        GameStateLogic.currentGameState = GameState.Playing;
                    }
                    break;
            }
        }
    }
}
