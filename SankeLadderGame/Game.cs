using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLadderGame
{
    internal class Game
    {
        public int playerPosition = 0, count = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        Random random = new Random();
        public int DiceRoll()
        {
            count++;
            int diceCount = random.Next(1, 7);
            Console.WriteLine("Die Roll Value" + "-" + count + "\nPlayer Position" + "-" + playerPosition);
            return diceCount;
        }
        public void Play()
        {
            while (playerPosition < 100)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        playerPosition += 0;
                        break;
                    case LADDER:
                        playerPosition += DiceRoll();
                        if (playerPosition > 100)
                        {
                            playerPosition -= DiceRoll();
                        }
                        break;
                    case SNAKE:
                        playerPosition -= DiceRoll();
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;
                }
            }
            if (playerPosition == WINNING_POSITION)
            {
                Console.WriteLine(playerPosition);
            }
        }
    }
}