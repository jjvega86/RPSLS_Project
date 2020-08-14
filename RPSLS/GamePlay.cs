using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        Player player1;
        Player player2;
        int maxRounds;
        int userInput;

        public GamePlay()
        {
            player1 = new Human("Player 1");
            maxRounds = 3;
            userInput = 0;
   
        }

        public void RunGame()
        {
            //string playAgain; //write an if statement that runs game again if user wants it to
            //need to re-run RunGame and reset all the initial values
            //method InitializeValues to set constructor 
            //can call to set the values later on after game has run

            GameWelcome();
            GameRules();
            ChooseRounds();
            DeterminePlayer2();
            PlayGame();
            DeclareWinner();
        }

       

        public void GameWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("It's a game based on statistical anecdotal evidence.");
            Console.ReadLine();

        }

        public void GameRules()
        {
            Console.WriteLine("You will take turns with another player. Each round, you and the other player will pick a gesture.\n");
            Console.WriteLine("One gesture always beats another. Whoever gets the most points wins!");
            Console.ReadLine();

        }

        public void ChooseRounds()
        {
           

            Console.WriteLine("How many rounds would you like to play (Minimum of 3)?");
            ValidatePlayerChoice();
            


            if (userInput >= 3)
            {
                maxRounds = userInput;
                Console.WriteLine($"Great! You're playing for best out of {maxRounds}!\n");

            }
            else
            {
                maxRounds = 3;
                Console.WriteLine("Three rounds it is!\n");

            }

        }
        public void DeterminePlayer2()
        {
            
            Console.WriteLine("Will you play alone, or with a friend?");
            Console.WriteLine("Choose 1 to play with a friend, or 2 to play alone!");
            ValidatePlayerChoice();

            
            if (userInput == 1)
            {
                player2 = new Human("Player 2");

            }
            else if (userInput == 2)
            {
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine("That isn't one of the options. Please try again!");
                DeterminePlayer2();
            }
            
        }

        public void ValidatePlayerChoice()
        {
            bool inputSuccess = false;
            
            while (inputSuccess == false)
            {
                inputSuccess = int.TryParse(Console.ReadLine(), out userInput);
                if (inputSuccess == false)
                {
                    Console.WriteLine("I didn't recognize that input. Please try again!");

                }
            }

        }

        public void PlayGame()
        {
            player1.name = player1.ChangeName();
            player2.name = player2.ChangeName();
            Console.WriteLine($"\nIt's {player1.name} vs. {player2.name}. Let's go!\n");

            //MVP - player1.score <maxRounds && player2.score < MaxRounds
            while (player1.score + player2.score < maxRounds)//does this work for every scenario?
            {
                CompareGestures(player1.AssignGesture(), player2.AssignGesture());
                Console.WriteLine("");
                PrintCurrentScore();
            }
            

        }

        public void PrintCurrentScore()
        {
            Console.WriteLine($"Currently, {player1.name} has {player1.score} and {player2.name} has {player2.score}!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        public void CompareGestures(Gesture gesture1, Gesture gesture2)
        {
            if (gesture1.name == gesture2.name)
            {
                Console.WriteLine("Draw!\n");

            }
            else if (gesture1.LosesTo.Contains(gesture2.name))
            {
                player2.score++;
                Console.WriteLine("Player 2 wins the round!\n");
            }
            else
            {
                player1.score++;
                Console.WriteLine("Player 1 wins the round!\n");

            }
        }



        public void DeclareWinner()
        {
            if (player1.score > player2.score)
            {
                Console.WriteLine($"The game winner is {player1.name}!");
                Console.ReadLine();
                
            }
            else if (player2.score > player1.score)
            {
                Console.WriteLine($"The game winner is {player2.name}!");
                Console.ReadLine();
              
            }
            else
            {
                Console.WriteLine("The game ends in a tie!");
                Console.ReadLine();

            }

        }
    }
}
