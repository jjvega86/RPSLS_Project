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

        public Player()
        {
            name = "Player X";
            score = 0;
            gestures = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
            
        }

        public virtual string ChangeName()
        {
            string newname;
            //take in user input to assign a string to the "name" variable
            return newname;
        }
    }
}
