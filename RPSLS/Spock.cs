﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Spock : Gesture
    {
        public Spock()
        {
            name = "Spock"; 
            LosesTo.Add("Paper");
            LosesTo.Add("Lizard");
        }
    }
}
