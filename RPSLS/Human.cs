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
            Console.WriteLine("Please choose your gesture!");
            gestureChoice = Console.ReadLine();
            return gestureChoice;
        }

    }
}
