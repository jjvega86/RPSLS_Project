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
            int gesturesIndex = 0;

            DisplayGestureOptions();
            Console.WriteLine($"Please choose your gesture, {name}!\n");
            gestureChoice = Console.ReadLine();
            ValidateGestureInput(gestureChoice);

            for (int i = 0; i < gestures.Count; i++)
            {
                if (gestures[i].name == gestureChoice)
                {
                    gesturesIndex = i;
                    
                }
            }

            return gestures[gesturesIndex];

        }

        public void ValidateGestureInput(string input)
        {
            bool inputValid = false;

            while (inputValid == false)
            {
                for (int i = 0; i < gestures.Count; i++)
                {
                    if (gestures[i].name == input)
                    {
                        inputValid = true;
                        gestureChoice = input;
                    }
                   
                }
                if (inputValid == false)
                {
                    Console.WriteLine("I'm sorry, I don't recognize that gesture.");
                    Console.WriteLine("Please enter your gesture exactly as you see it!\n");
                    input = Console.ReadLine();
                    
                }
            }
          

        }

    }
}
