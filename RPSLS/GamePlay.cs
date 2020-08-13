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
        int maxScore;

        public GamePlay()
        {
            player1 = new Human("Player 1");
            maxScore = 3;
   
        }

        public void RunGame()
        {
            //Contains all other GamePlay method, and is the only method that will run in Program.cs
            GameWelcome();
            GameRules();
            ChooseRounds();
            DeterminePlayer2();
            PlayGame();
            DeclareWinner();
        }

       

        public void GameWelcome()
        {
            

        }

        public void GameRules()
        {
            //Greets player, explains rules
            //best of 3 minimum ACCORDING TO USER STORY

        }

        public void ChooseRounds()
        {
            Console.WriteLine("How many rounds would you like to play?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            maxScore = userInput;
        }
        public void DeterminePlayer2()
        {
            Console.WriteLine("Will you play alone, or with a friend?");
            Console.WriteLine("Choose 1 for alone, or 2 to play with a friend!");
            int userInput = Convert.ToInt32(Console.ReadLine());


            if (userInput == 1)
            {
                player2 = new Computer();
            }
            else
            {
                player2 = new Human("Player 2");
            }
        }



        public void PlayGame()
        {
            player1.name = player1.ChangeName();
            player2.name = player2.ChangeName();
            Console.WriteLine($"It's {player1.name} vs. {player2.name}. Let's go!");

            while (player1.score < maxScore && player2.score < maxScore)
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
