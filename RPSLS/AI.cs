using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        List<string> namechoices;

        public AI()
            
        {
            namechoices = new List<string>() {"Bob", "Rob", "Cobb"};
            name = "Robot";
        }

        public override string ChangeName()
        {
            Random random = new Random();
            string newname = namechoices[random.Next(namechoices.Count - 1)];
            return newname;
        }
    }
}
