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
        Human player2a;
        AI player2b;

        public GamePlay()
        {
            player1 = new Human("Player 1");
            player2a = new Human("Player 2");
            player2b = new AI();

        }

        public void RunGame()
        {
            //Contains all other GamePlay method, and is the only method that will run in Program.cs
            GameIntroduction();
            DeclareWinner(Game(ChooseGameMode()));


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

        public string Game(int gametype)
        {
            string gamewinner = "Default";

            if (gametype == 1)
            {
                //solo game w/ AI player
                player1.name = player1.ChangeName();
                player2b.name = player2b.ChangeName();
                SoloGame();

            }
            else if (gametype == 2)
            {
                //multiplayer game w/ two humans
                player1.name = player1.ChangeName();
                player2a.name = player2a.ChangeName();
                MultiplayerGame();
            }
            else
            {
                Console.WriteLine("Hmmmm, you must have chosen the wrong option. Please try again!");
                //gametype = ChooseGameMode();
                //how to get it to restart the whole method after they choose their game mode again?***
            }

            return gamewinner;

            

        }

        public void SoloGame()//return string winner
        {
            Console.WriteLine($"It's {player1.name} vs. {player2b.name}. Let's go!");
            player1.AssignGesture();
            player2b.AssignGesture();

            //Method call to compare gestures and determine what wins
            //Update the score of winning player
            //logic to determine who wins based on each player's score

            //player 1 chooses gesture
            //player 2 AI gesture chosen at random
            //repeat until winner
            //Human vs. AI

        }

        public void MultiplayerGame() //return string winner
        {
            Console.WriteLine($"It's {player1.name} vs. {player2a.name}. Let's go!");
            player1.AssignGesture(); 
            player2a.AssignGesture();

            //Method call to compare gestures and determine what wins
            //Update the score of winning player
            //logic to determine who wins based on each player's score

            //Human vs. Human
            //player 1 chooses gesture
            //player 2 chooses gesture
            //repeat until winner
            //Human vs. AI
        }

        public void DeclareWinner(string winner)
        {
            //takes the return of GameRound for the game winner, outputs a winning message
            //asks if you would like to play again, restarts the whole thing if yes
            Console.WriteLine($"The game winner is {winner}!");
            Console.ReadLine();

        }
    }
}
