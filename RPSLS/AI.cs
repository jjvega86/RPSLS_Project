using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        List<string> nameChoices;
        Random random;


        public AI()
           
        {
            nameChoices = new List<string>() {"Bob", "Rob", "Cobb", "Cindy", "Carol", "Tommy"};
            name = "WALL-E";
            random = new Random();
        }

        public override string ChangeName()
        {
            string newName = nameChoices[random.Next(nameChoices.Count + 1)];
            return newName;
        }

        public override string AssignGesture()
        {
            gestureChoice = gestures[random.Next(gestures.Count + 1)].name;
            return gestureChoice;
        }
    }
}
