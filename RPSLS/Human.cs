using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        
        public Human(string name)
            
        {
            this.name = name;
        }

        public override Gesture AssignGesture()
        {

            DisplayGestureOptions();
            Console.WriteLine($"Please choose your gesture, {name}!");
            gestureChoice = Console.ReadLine();
            ValidateGestureInput(gestureChoice);

            int gesturesIndex = 0;

            for (int i = 0; i < gestures.Count; i++)
            {
                if (gestures[i].name == gestureChoice)
                {
                    gesturesIndex = i;
                    
                }
            }

            return gestures[gesturesIndex];

        }

        public void ValidateGestureInput(string input) //REDO WITH NO DEPENDENCY IN ASSIGN METHOD
        {
            bool inputValid = false;

            for (int i = 0; i < gestures.Count; i++)
            {
                if (gestures[i].name == input)
                {
                    inputValid = true;
                }
               
            }

            if (inputValid == false)
            {
                Console.WriteLine("I'm sorry, I don't recognize that gesture.");
                Console.WriteLine("Please enter your gesture exactly as you see it!");
                Console.WriteLine("");
                AssignGesture(); //dependency - look at the GamePlay class w/ while loop and bool returns to break this dependency
            }

        }

    }
}
