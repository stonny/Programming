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
        public static void CallGameStateLogic(GameTime gameTime, Player spaceShip, ContentManager Content, BackgroundPicture background, List<Enemy> chickens, List<EnemyAttack> attacks)
        {
            //private float playTime;
            playTime += (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentGameState)
            {
                case GameState.Playing:
                    if (spaceShip.PlayerScore == 0)                              
                    {
                        EnemyLogic.chickenNumber = 5;
                        EnemyLogic.enemyIntervalSeconds = 1;
                        background.Update();
                        background.Texture = Content.Load<Texture2D>("Images\\background");
                        spaceShip.PlayerLevel = "1";                       
                        chickens.Clear();
                        attacks.Clear();
                        currentGameState = GameState.Beggining;
                    }
                    break;
                case GameState.Beggining:
                    if (spaceShip.PlayerScore == 150)
                    {
                        background.Update();
                        background.Texture = Content.Load<Texture2D>("Images\\background2");                        
                        spaceShip.PlayerLevel = "2";
                        spaceShip.PlayerLives++;
                        currentGameState = GameState.ChickenMeatballs;
                    }

                    break;
                case GameState.ChickenMeatballs:
                    if (spaceShip.PlayerScore == 300)
                    {
                        background.Update();
                        background.Texture = Content.Load<Texture2D>("Images\\background3");
                        spaceShip.PlayerLevel = "3";
                        EnemyLogic.chickenNumber += 2;
                        EnemyLogic.enemyIntervalSeconds -= 0.2f;
                        spaceShip.PlayerLives++;
                        currentGameState = GameState.TheUltimateChickenBattle;
                    }
                    break;
                case GameState.TheUltimateChickenBattle:
                    if (spaceShip.PlayerScore == 450)
                    {
                        background.Update();
                        background.Texture = Content.Load<Texture2D>("Images\\background4");
                        spaceShip.PlayerLevel = "SURVIVE THIS !";
                        EnemyLogic.chickenNumber += 15;
                        EnemyLogic.enemyIntervalSeconds -= 0.5f;
                        spaceShip.PlayerLives++;
                        currentGameState = GameState.Survive;
                    }
                    break;
                case GameState.Survive:
                    if (spaceShip.PlayerScore == 600)
                    {
                        background.Update();
                        background.Texture = Content.Load<Texture2D>("Images\\background5");
                        spaceShip.PlayerLevel = "OK... TOUGH GUY...";
                        EnemyLogic.chickenNumber += 50;
                        EnemyLogic.enemyIntervalSeconds -= 0.5f;
                        spaceShip.PlayerLives++;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
