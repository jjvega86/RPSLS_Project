using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        Human player1;
        Human player2;
        AI player0;

        public GamePlay()
        {
            player1 = new Human("Player 1");
            player2 = new Human("Player 2");
            player0 = new AI("Player 0");

        }

        public void RunGame()
        {
            //Contains all other GamePlay method, and is the only method that will run in Program.cs

        }

        public void GameIntroduction()
        {
            //Greets player, explains rules

        }

        public void ChooseGameMode()
        {
            //Will allow player to choose between single player and multiplayer mode
            //In multiplayer, game expects input for both player objects
            //In single player, game expects input for one player object, but randomizes output
            //from the other player object
        }

        public void GameRound()
        {
            //player 1 chooses gesture
            //player 2 chooses gesture
            //
        }
    }
}
