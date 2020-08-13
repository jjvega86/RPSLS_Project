using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        Player player1;
        Player player2;

        public GamePlay()
        {
            player1 = new Player();
            player2 = new Player();

        }

        public void RunGame()
        {
            //Contains all other GamePlay method, and is the only method that will run in Program.cs
            GameIntroduction();
            GameRound(ChooseGameMode());


        }

        public void GameIntroduction()
        {
            //Greets player, explains rules

        }

        public int ChooseGameMode()
        {
            //Will allow player to choose between single player and multiplayer mode
            //In multiplayer, game expects input for both player objects
            //In single player, game expects input for one player object, but randomizes output
            //from the other player object

            Console.WriteLine("Will you play alone, or with a friend?");
            Console.WriteLine("Choose 1 for alone, or 2 to play with a friend!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;

        }

        public void GameRound(int gametype)
        {
            if (gametype == 1)
            {
                //solo game w/ AI player
                SoloGameRound();

            }
            else if (gametype == 2)
            {
                //multiplayer game w/ two humans
                MultiplayerGameRound();
            }
            else
            {
                Console.WriteLine("Hmmmm, you must have chosen the wrong option. Please try again!");
                //gametype = ChooseGameMode();
                //how to get it to restart the whole method after they choose their game mode again?
            }

            

        }

        public void SoloGameRound()
        {
            //player 1 chooses gesture
            //player 2 chooses gesture
            //Human vs. AI
        }

        public void MultiplayerGameRound()
        {
            //Human vs. Human
        }

        public void DeclareWinner()
        {
            //takes the return of GameRound for the game winner, outputs a winning message
            //asks if you would like to play again, restarts the whole thing if yes
        }
    }
}
