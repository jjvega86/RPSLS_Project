using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gesture
    {
        public string name;
        //what member variable would all of them share to help with battle logic?
        public Gesture()
        {
            name = "Default";

        }
    }
}
