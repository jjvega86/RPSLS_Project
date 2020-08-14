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

        public override string AssignGesture()
        {
            //validation: if gestureChoice doesn't equal the gesture option exactly, reprompt for input
            DisplayGestureOptions();
            Console.WriteLine($"Please choose your gesture, {name}!");
            gestureChoice = Console.ReadLine();
            Console.WriteLine("");
            ValidateInput(gestureChoice);
            return gestureChoice;
        }

        public void ValidateInput(string input)
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
                AssignGesture();
            }

        }

    }
}
