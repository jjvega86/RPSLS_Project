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
            player1 = new Human("Player 1");
   
        }

        public void RunGame()
        {
            //Contains all other GamePlay method, and is the only method that will run in Program.cs
            GameWelcome();
            GameRules();
            DeterminePlayer2();
            PlayGame();
            DeclareWinner();
        }

        public void DeterminePlayer2()
        {
            Console.WriteLine("Will you play alone, or with a friend?");
            Console.WriteLine("Choose 1 for alone, or 2 to play with a friend!");
            int userInput = Convert.ToInt32(Console.ReadLine());
       

            if (userInput == 1)
            {
                player2 = new AI();
            }
            else
            {
                player2 = new Human("Player 2");
            }
        }

        public void GameWelcome()
        {
            

        }

        public void GameRules()
        {
            //Greets player, explains rules
            //Choose number of rounds?
            //best of 3

        }

    

        public void PlayGame()
        {
            player1.name = player1.ChangeName();
            player2.name = player2.ChangeName();
            Console.WriteLine($"It's {player1.name} vs. {player2.name}. Let's go!");

            while (player1.score < 3 && player2.score < 3)
            {
                CompareGestures(player1.AssignGesture(), player2.AssignGesture());

            }

        }

        public void CompareGestures(string gesture1, string gesture2)
        {
            if(gesture1 == "Rock" && gesture2 == "Scissors")
            {
                player1.score++;
            }
            //Player 1 gets a point, Player 2 gets a point, Draw

        }


        public void DeclareWinner()
        {
            string winner;
            //takes the return of GameRound for the game winner, outputs a winning message
            //asks if you would like to play again, restarts the whole thing if yes
            if (player1.score > player2.score)
            {
                winner = player1.name;
            }
            else
            {
                winner = player2.name;
            }


            Console.WriteLine($"The game winner is {winner}!");
            Console.ReadLine();

        }
    }
}
