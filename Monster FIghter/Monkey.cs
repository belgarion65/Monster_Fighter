using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_FIghter
{
    class Monkey : Pet
    {
        public Monkey(string name, string breed) : base(name, breed)
        {
        }

        public override string MakeNoise()
        {
            return "HASAKI";
        }
    }
}
