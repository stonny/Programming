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
    public class Player : GameObject, IMoveable
    {
        // Fields to initialize player health and movement speed
        protected int playerLives;
        protected string playerLevel = 1.ToString();
        protected int playerScore = 0;
        protected int playerSpeed;

        // Constructor that initializes the objec's form, size (as rectangle), Health of Player and Speed
        public Player(Texture2D texture, Rectangle form, byte health, int speed)
        {
            this.texture = texture;
            this.form = form;
            this.PlayerLives = health;
            this.PlayerSpeed = speed;
        }

        // Setting the X coordinates for the Player
        public int PositionX
        {
            get { return this.form.X; }
            set { this.form.X = value; }
        }

        // Setting the Y coordinates for the Player
        public int PositionY
        {
            get { return this.form.Y; }
            set { this.form.Y = value; }
        }

        // Setting Player Health
        public int PlayerLives
        {
            get { return this.playerLives; }
            set 
            {
                this.playerLives = value;
                if (value < -2)
                {
                    throw new OutOfRangeException("Players lives can't be negative");
                }
            }
        }

        // Setting the Player Level
        public string PlayerLevel
        {
            get { return this.playerLevel; }
            set 
            {
                this.playerLevel = value;
            }
        }
        // Setting the Player current Score
        public int PlayerScore
        {
            get { return this.playerScore; }
            set 
            { 
                this.playerScore = value;
                if (value < 0)
                {
                    throw new OutOfRangeException("Players score can't be negative");
                }
            }
        }
        // Setting Player Movement Speed
        public int PlayerSpeed
        {
            get { return this.playerSpeed; }
            set { this.playerSpeed = value; }
        }      
        /// <summary>
        /// This Method is overrided because it has different behaviour for this class.
        /// The targe of this method is to move the Player with the Arrow Keys
        /// </summary>
        public override void Update()
        {
            // Moving right
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                this.form.X += playerSpeed;
            }
            // Moving left
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.form.X -= playerSpeed;
            }

            // Movement up
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                this.form.Y -= playerSpeed;
            }
            
            // Movement down
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                this.form.Y += playerSpeed;
            }   
        }

        /// <summary>
        /// This Method target is to restrict the movement of the Player object
        /// so it doesn't leave the bound of the console.
        /// </summary>
        /// <param name="graphic"></param>
        public void RestrictMovement(GraphicsDeviceManager graphic)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                if (form.X <= 0)
                {
                    this.form.X =0;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                if (form.X >= graphic.PreferredBackBufferWidth-50)
                {
                    this.form.X = graphic.PreferredBackBufferWidth -50;
                } 
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (form.Y <= 0)
                {
                    this.form.Y = 0;
                } 
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                if (form.Y >= graphic.PreferredBackBufferHeight-60)
                {
                    this.form.Y = graphic.PreferredBackBufferHeight -60;
                } 
            }
        }
    }
}
