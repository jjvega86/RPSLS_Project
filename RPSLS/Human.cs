using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        
        public Human(string name)
            :base(name)
        {
            this.name = name;

        }
    }
}
