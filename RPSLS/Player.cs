using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //should contain a list of possible gestures
        //could contain a variable for current score

        public string name;
        public int score;
        public List<Gesture> gestures;
        public string gestureChoice;

        public Player()
        {
            name = "Default";
            score = 0;
            gestures = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
            gestureChoice = "Default";
           
        }

        public virtual string ChangeName()
        {
            //take in user input to assign a string to the "name" variable

            Console.WriteLine($"Please enter your name, {name}!");
            string newname = Console.ReadLine();
            return newname;
        }

        public void DisplayGestureOptions()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gestures[i].name);

            }
        }

        public virtual string AssignGesture()
        {
            //validation: if gestureChoice doesn't equal the gesture option exactly, reprompt for input
            DisplayGestureOptions();
            Console.WriteLine("Please choose your gesture!");
            gestureChoice = Console.ReadLine();
            return gestureChoice;
        }

        
    }
}
