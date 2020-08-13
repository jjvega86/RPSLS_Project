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
        int maxRounds;

        public GamePlay()
        {
            player1 = new Human("Player 1");
            maxRounds = 3;
   
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
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("It's a game based on statistical anecdotal evidence.");
            Console.ReadLine();
            

        }

        public void GameRules()
        {
            Console.WriteLine("You will take turns with another player. Each round, you and the other player will pick a gesture.");
            player1.DisplayGestureOptions();
            Console.WriteLine("");
            Console.WriteLine("One gesture always beats another. Whoever gets the most points wins!");
            Console.ReadLine();

        }

        public void ChooseRounds()
        {
            Console.WriteLine("How many rounds would you like to play?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            maxRounds = userInput;
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

            while (player1.score < maxRounds && player2.score < maxRounds)
            {
                CompareGestures(player1.AssignGesture(), player2.AssignGesture());
                Console.WriteLine("");

            }

        }

        public void CompareGestures(string gesture1, string gesture2)
        {
            if(gesture1 == "Rock" && gesture2 == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors!");
                player1.score++;
            }
            else if (gesture1 == "Scissors" && gesture2 == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper!");
                player1.score++;
            }
            else if(gesture1 == "Paper" && gesture2 == "Rock")
            {
                Console.WriteLine("Paper covers Rock!");
                player1.score++;
            }
            else if(gesture1 == "Rock" && gesture2 == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
                player1.score++;
            }
            else if(gesture1 == "Lizard" && gesture2 == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
                player1.score++;
            }
            else if(gesture1 == "Spock" && gesture2 == "Sicssors")
            {
                Console.WriteLine("Spock smashes Scissors!");
                player1.score++;
            }
            else if(gesture1 == "Scissors" && gesture2 == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                player1.score++;
            }
            else if(gesture1 == "Lizard" && gesture2 == "Paper")
            {
                Console.WriteLine("Lizard eats Paper!");
                player1.score++;
            }
            else if(gesture1 == "Paper" && gesture2 == "Spock")
            {
                Console.WriteLine("Paper disapproves Spock!");
                player1.score++;
            }
            else if(gesture1 == "Spock" && gesture2 == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
                player1.score++;
            }
            else if(gesture2 == "Rock" && gesture1 == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors!");
                player2.score++;
            }
            else if(gesture2 == "Scissors" && gesture1 == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper!");
                player2.score++;
            }
            else if(gesture2 == "Paper" && gesture1 == "Rock")
            {
                Console.WriteLine("Paper covers Rock!");
                player2.score++;
            }
            else if(gesture2 == "Rock" && gesture1 == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard!");
                player2.score++;
            }
            else if(gesture2 == "Lizard" && gesture1 == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock!");
                player2.score++;
            }
            else if(gesture2 == "Spock" && gesture1 == "Sicssors")
            {
                Console.WriteLine("Spock smashes Scissors!");
                player2.score++;
            }
            else if(gesture2 == "Scissors" && gesture1 == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard!");
                player2.score++;
            }
            else if(gesture2 == "Lizard" && gesture1 == "Paper")
            {
                Console.WriteLine("Lizard eats Paper!");
                player2.score++;
            }
            else if(gesture2 == "Paper" && gesture1 == "Spock")
            {
                Console.WriteLine("Paper disapproves Spock!");
                player2.score++;
            }
            else if(gesture2 == "Spock" && gesture1 == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock!");
                player2.score++;
            }
            else
            {
                Console.WriteLine("Draw!");
                //MaxRound-- to decrement the game total? This would make a better "2 out of 3" scenario.
                //get it working first
            }

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
