﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Paper : Gesture
    {
        public Paper()
        {
            name = "Paper";
            LosesTo.Add("Scissors");
            LosesTo.Add("Lizard");
        }
    }
}
