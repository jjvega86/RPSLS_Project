﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Scissors : Gesture
    {
        public Scissors()
        {
            name = "Scissors";
            LosesTo.Add("Rock");
            LosesTo.Add("Spock");
        }
    }
}
