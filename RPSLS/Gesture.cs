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
        public List<string> LosesTo;
        public Gesture()
        {
            name = "Default";
            LosesTo = new List<string>();

        }
    }
}
