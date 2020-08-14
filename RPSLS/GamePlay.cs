﻿using System;
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

        public GamePlay()
        {
            player1 = new Human("Player 1");
            maxRounds = 3; 
   
        }

        public void RunGame()
        {
            //string playAgain; //write an if statement that runs game again if user wants it to

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
            Console.WriteLine("You will take turns with another player. Each round, you and the other player will pick a gesture.");
            Console.WriteLine("");
            Console.WriteLine("One gesture always beats another. Whoever gets the most points wins!");
            Console.ReadLine();

        }

        public void ChooseRounds()
        {
            int userInput;
            bool inputSuccess;

            Console.WriteLine("How many rounds would you like to play (Minimum of 3)?");
            inputSuccess = int.TryParse(Console.ReadLine(), out userInput);
            while (inputSuccess == false)
            {
                Console.WriteLine("I didn't recognize that input. Please try again!");
                inputSuccess = int.TryParse(Console.ReadLine(), out userInput);

            }
            //int userInput = int.Parse((Console.ReadLine());
            //Is there a parse check I could run in case the user doesn't enter an integer?


            if (userInput >= 3)
            {
                maxRounds = userInput;
                Console.WriteLine($"Great! You're playing for best out of {maxRounds}!");
                Console.WriteLine("");

            }
            else
            {
                maxRounds = 3;
                Console.WriteLine("Three rounds it is!");
                Console.WriteLine("");

            }

        }
        public void DeterminePlayer2()
        {
            Console.WriteLine("Will you play alone, or with a friend?");
            Console.WriteLine("Choose 1 to play with a friend, or 2 to play alone!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //check for successful parse, reprompt for input if user doesn't enter an INT

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
                ValidatePlayerChoice();
            }
        }

        public void ValidatePlayerChoice()
        {
            Console.WriteLine("I'm sorry, that choice isn't valid. Please try again!");
            Console.WriteLine("");
            DeterminePlayer2();

        }

        public void PlayGame()
        {
            player1.name = player1.ChangeName();
            player2.name = player2.ChangeName();
            Console.WriteLine("");
            Console.WriteLine($"It's {player1.name} vs. {player2.name}. Let's go!");
            Console.WriteLine("");

            while (player1.score + player2.score < maxRounds)
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

        public void CompareGestures(string gesture1, string gesture2)
        {
            if(gesture1 == "Rock" && gesture2 == "Scissors")
            {
                Console.WriteLine($"Rock crushes Scissors! {player1.name} wins.");
                player1.score++;
            }
            else if (gesture1 == "Scissors" && gesture2 == "Paper")
            {
                Console.WriteLine($"Scissors cuts Paper! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Paper" && gesture2 == "Rock")
            {
                Console.WriteLine($"Paper covers Rock! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Rock" && gesture2 == "Lizard")
            {
                Console.WriteLine($"Rock crushes Lizard! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Lizard" && gesture2 == "Spock")
            {
                Console.WriteLine($"Lizard poisons Spock! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Spock" && gesture2 == "Sicssors")
            {
                Console.WriteLine($"Spock smashes Scissors! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Scissors" && gesture2 == "Lizard")
            {
                Console.WriteLine($"Scissors decapitates Lizard! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Lizard" && gesture2 == "Paper")
            {
                Console.WriteLine($"Lizard eats Paper! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Paper" && gesture2 == "Spock")
            {
                Console.WriteLine($"Paper disapproves Spock! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture1 == "Spock" && gesture2 == "Rock")
            {
                Console.WriteLine($"Spock vaporizes Rock! {player1.name} wins.");
                player1.score++;
            }
            else if(gesture2 == "Rock" && gesture1 == "Scissors")
            {
                Console.WriteLine($"Rock crushes Scissors! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Scissors" && gesture1 == "Paper")
            {
                Console.WriteLine($"Scissors cuts Paper! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Paper" && gesture1 == "Rock")
            {
                Console.WriteLine($"Paper covers Rock! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Rock" && gesture1 == "Lizard")
            {
                Console.WriteLine($"Rock crushes Lizard! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Lizard" && gesture1 == "Spock")
            {
                Console.WriteLine($"Lizard poisons Spock! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Spock" && gesture1 == "Sicssors")
            {
                Console.WriteLine($"Spock smashes Scissors! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Scissors" && gesture1 == "Lizard")
            {
                Console.WriteLine($"Scissors decapitates Lizard! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Lizard" && gesture1 == "Paper")
            {
                Console.WriteLine($"Lizard eats Paper! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Paper" && gesture1 == "Spock")
            {
                Console.WriteLine($"Paper disapproves Spock! {player2.name} wins.");
                player2.score++;
            }
            else if(gesture2 == "Spock" && gesture1 == "Rock")
            {
                Console.WriteLine($"Spock vaporizes Rock! {player2.name} wins.");
                player2.score++;
            }
            else
            {
                Console.WriteLine("Draw!");
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
