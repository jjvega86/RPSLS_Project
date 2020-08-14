using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player //abstract because Player object is never instantiated
    {
        public string name;
        public int score;
        public List<Gesture> gestures;
        public string gestureChoice;

        public Player() //every player has a gestures list, regardless of what KIND of player
        {
            name = "Default";
            score = 0;
            gestures = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
            gestureChoice = "Default";
           
        }

        public virtual void ChangeName() //used in all child classes
        {
            Console.WriteLine($"\nPlease enter your name, {name}!");
            name = Console.ReadLine();
        }

        public void DisplayGestureOptions()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gestures[i].name);

            }
            Console.WriteLine("");
        }

        public abstract Gesture AssignGesture(); 
        //this forces child classes to declare their version of this method with unique logic
        //doesn't need code logic here because Player object is never instantiated
        //and, each child will do it differently
        


    }
}
