using System;
using System.Linq;

namespace _04.Minesweeper
{
    public class Points
    {
        private string playerName;
        private int playerPoints;

        public Points()
        {
        }

        public Points(string name, int points)
        {
            this.playerName = name;
            this.playerPoints = points;
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PlayerPoints
        {
            get { return this.playerPoints; }
            set { this.playerPoints = value; }
        }
    }
}
