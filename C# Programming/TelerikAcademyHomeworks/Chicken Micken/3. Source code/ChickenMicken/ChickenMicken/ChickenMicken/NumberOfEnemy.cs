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
   public class NumberOfEnemy
    {
        private static Random rand;
        static NumberOfEnemy()
        {
            rand = new Random();
        }
       //genetrate random position of the enemy
        public static int Generate(int numberX, int numberY)
        {
            return rand.Next(numberX+1, numberY );
        }
    }
}
