using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        List<string> nameChoices;
        Random random;


        public Computer()
           
        {
            nameChoices = new List<string>() {"Bob", "Rob", "Cobb", "Cindy", "Carol", "Tommy"};
            name = "WALL-E";
            random = new Random();
        }

        public override void ChangeName()
        {
            name = nameChoices[random.Next(nameChoices.Count)];
            
        }

        public override Gesture AssignGesture()
        {
            return gestures[random.Next(gestures.Count)];
                       
        }
    }
}
