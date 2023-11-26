using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class TotalAmountOfPoints
    {
        public int TotalPoints(string[] games)
        {
            int score = 0;

            foreach(string game in games)
            {
                if (int.Parse(game.Substring(0, 1)) > int.Parse(game.Substring(2, 1)))
                {
                    score += 3;
                }
                else if (int.Parse(game.Substring(0, 1)) == int.Parse(game.Substring(2, 1)))
                {
                    score += 1;
                }
            }
            return score;
        }
    }
}
