using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLadderGame
{
    internal class Game
    {
        public int playerPosition = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            int diceCount = random.Next(1, 7);
            return diceCount;
        }
    }
}
