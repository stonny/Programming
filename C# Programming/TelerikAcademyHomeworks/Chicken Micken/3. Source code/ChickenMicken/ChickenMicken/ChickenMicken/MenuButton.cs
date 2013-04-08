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
    /// <summary>
    /// This class target is to define the buttons of the menu and draw them on the screen.
    /// </summary>
    public class MenuButton : MouseMoves
    {

        protected Texture2D TextureButton { get; set; }
        //make button
        public MenuButton(Texture2D newTexture, GraphicsDevice graphics)
        {
            this.TextureButton = newTexture;
            base.Size = new Vector2(graphics.Viewport.Width / 6, graphics.Viewport.Height / 7);
        }
        //set the position of the button
        public void SetPositionOfButton(Vector2 newPosition)
        {
            base.PositionB = newPosition;
        }
        //draw the button
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TextureButton, FormButton, colorButton);
        }
        public void DrawButton(GameState currentGamestate, SpriteBatch spriteBatch, ContentManager Content, int WindowWidth, int WindowHeight)
        {
            if (currentGamestate == GameState.MainMenu)
            {
                spriteBatch.Draw(Content.Load<Texture2D>("Images\\BackgroundMainMenu"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);
                Draw(spriteBatch);
            }
        }
    }
}
