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
    public static class GameStateLogic
    {
        public static float playTime { get; set; }
        public static GameState currentGameState = GameState.MainMenu;
        public static void CallGameStateLogic(GameTime gameTime, Player spaceShip)
        {
            //private float playTime;
            playTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
            switch (currentGameState)
            {
                case GameState.Playing:
                    if (playTime > 30)                              // If the playtime reaches 30
                    {
                        currentGameState = GameState.ChickenMeatballs; // Change the CurrentGameState
                        spaceShip.PlayerLevel++;                      
                    }
                    break;
                case GameState.ChickenMeatballs:
                    if (playTime > 50)
                    {
                        currentGameState = GameState.TheUltimateChickenBattle;
                        spaceShip.PlayerLevel++;
                    }
                    break;
                case GameState.TheUltimateChickenBattle:
                    if (playTime > 70)
                    {
                        currentGameState = GameState.GameOver;
                        spaceShip.PlayerLevel++;
                    }
                    break;
                case GameState.GameOver:
                    //GameOverTitle();
                    break;

                default:
                    break;
            }
        }
        public static void BackgroundUpdate(ContentManager Content, BackgroundPicture backgroundOne, BackgroundPicture backgroundTwo)
        {
            backgroundOne.Update();
            backgroundTwo.Update();

            if (currentGameState == GameState.ChickenMeatballs)
            {
                backgroundOne.Texture = Content.Load<Texture2D>("Images\\background2");
            }
            if (currentGameState == GameState.TheUltimateChickenBattle)
            {
                backgroundOne.Texture = Content.Load<Texture2D>("Images\\background3");
            }
        }
    }
}
