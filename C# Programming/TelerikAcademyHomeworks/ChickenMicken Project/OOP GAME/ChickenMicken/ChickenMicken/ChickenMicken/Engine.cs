using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Threading;

namespace ChickenMicken
{
    public class Engine : Microsoft.Xna.Framework.Game
    {
        // Creating new instance of the objects that we use in the game
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player spaceShip;      
        KeyboardState presentKey;
        KeyboardState pastKey;
        SpriteFont font;
        BackgroundPicture backgroundOne;
        BackgroundPicture backgroundTwo;
        BackgroundPicture gameOver;
        IGameStats drawGameStats = new GameStats();
        List<PlayerAttack> spaceShipAttacks = new List<PlayerAttack>();
        List<EnemyAttack> bullets = new List<EnemyAttack>();
        List<Enemy> chickensList = new List<Enemy>();
        List<Explosion> explosions = new List<Explosion>();
        cButton btnPlay;

        // Setting the Screen Resolution
        int WindowHeight = 660;
        int WindowWidth = 800;

        // Setting the Player Statistics
        int playerLives = 3;
        int playerMovementSpeed = 10;

        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            graphics.PreferredBackBufferHeight = WindowHeight;
            graphics.PreferredBackBufferWidth = WindowWidth;
            //apply grafics
            graphics.ApplyChanges();
            IsMouseVisible = true;
            // loading the button
            btnPlay = new cButton(Content.Load<Texture2D>("Images\\PlayButton"), graphics.GraphicsDevice);
            //set position of button
            btnPlay.SetPositionOfButton(new Vector2(350, 350));
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load the spaceShip that will act as a Player
            spaceShip = new Player(this.Content.Load<Texture2D>("Images\\spaceship"), new Rectangle(370, 600, 50, 50), playerLives, playerMovementSpeed);

            // Load the Background of the Window
            backgroundOne = new BackgroundPicture(this.Content.Load<Texture2D>("Images\\background"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);
            backgroundTwo = new BackgroundPicture(this.Content.Load<Texture2D>("Images\\background2"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);
            gameOver = new BackgroundPicture(this.Content.Load<Texture2D>("Images\\GameOver"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);

            // Load the Font that will be used to write to the Screen
            font = Content.Load<SpriteFont>("Fonts\\GameStatsFont");
           
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // get state of the mouse
            MouseState mouse = Mouse.GetState();

            // Checking the state of the key - if it is pressed
            presentKey = Keyboard.GetState();

            // Restricting the movements of the Player in the bounds of the screen
            spaceShip.RestrictMovement(graphics);

            // Updating the Player Position
            spaceShip.Update();

            // Adding attacks to the List and updating their position
            PlayerLogic.SpaceShipAttacksAdd(Content, spaceShip, spaceShipAttacks, presentKey, pastKey);
            PlayerLogic.AttackUpdate(graphics.GraphicsDevice, spaceShip, spaceShipAttacks, presentKey, pastKey);

            // Generating chickens at random position and updating them
            EnemyLogic.ChickenGenerator(gameTime, chickensList, Content);
            EnemyLogic.ChickenUpdate(graphics.GraphicsDevice, chickensList);

            // Collision between player attacks and enemies attack
            Collision.CollisionPlayerAttacksToEnemy(Content, spaceShipAttacks, chickensList, explosions, spaceShip);

            // Update Explosions
            Collision.ExplosionUpdate(explosions);

            // Collision of bullets with player
            Collision.CollisionEnemychickenAttacksToPlayer(Content, spaceShip, bullets, explosions);

            // Collision Player WIth Enemy
            Collision.CollisionPlayerToEnemy(Content, spaceShip, chickensList, explosions);

            // Generates Random attacks from the chickens and updating their positions
            BulletGenerator.BulletGeneratorAttack(gameTime, chickensList, Content, bullets);
            BulletGenerator.BulletUpdate(bullets);

            // Creating game state
            GameStateLogic.CallGameStateLogic(gameTime, spaceShip);
            GameStateLogic.BackgroundUpdate(Content, backgroundOne, backgroundTwo);

            // main menu logic (update mouse)
            //MenuLogic menu = new MenuLogic();

            btnPlay.CallButtonLogic(GameStateLogic.currentGameState,mouse);
            //menu.Update(mouse);
            

            base.Update(gameTime);

            // Checking the state of the key if it is released
            pastKey = presentKey;
           

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // Begining the Draw on the Screen
            spriteBatch.Begin();

            if (spaceShip.PlayerHealth < 0)
            {
                gameOver.Draw(spriteBatch);
                if (Keyboard.GetState().IsKeyDown(Keys.N))
                {
                    Exit();
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Y))
                {
                    spaceShip.PlayerHealth = 3;
                    spaceShip.PlayerScore = 0;
                    spaceShip.PlayerLevel = 0;
                    GameStateLogic.CallGameStateLogic(gameTime, spaceShip);
                    
                }
            }
            else
            {
                // Draw the Background
                backgroundOne.Draw(spriteBatch);

                // Draw the Player
                spaceShip.Draw(spriteBatch);

                // Draw Player Attacks
                PlayerLogic.DrawAttacks(spaceShipAttacks, spriteBatch, font);

                // Drawing the Enemies
                foreach (var chicken in chickensList)
                {
                    chicken.Draw(spriteBatch);
                }

                // Draw the Enemy Attacks
                BulletGenerator.DrawBullet(bullets, spriteBatch, font);

             // Draw the Explosions/Deaths 
                Collision.DrawExplosions(explosions, spriteBatch);            

            // Draw the Game Stats on the Screen
            drawGameStats.DrawLives(spaceShip, spriteBatch, font, 10, 10);
            drawGameStats.DrawScore(spaceShip, spriteBatch, font, 600, 10);
            drawGameStats.DrawLevel(spaceShip, spriteBatch, font, 10, 35);
            //draw the menu on screen
            btnPlay.DrawButton(GameStateLogic.currentGameState, spriteBatch, Content, this.WindowWidth, this.WindowHeight);


            if (GameStateLogic.currentGameState != GameState.MainMenu)
            {
                // Draw the Game Stats on the Screen
                drawGameStats.DrawLives(spaceShip, spriteBatch, font, 10, 10);
                drawGameStats.DrawScore(spaceShip, spriteBatch, font, 600, 10);
                drawGameStats.DrawLevel(spaceShip, spriteBatch, font, 10, 35);

            }
            }
            // Ending the Draw on the Screen
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
