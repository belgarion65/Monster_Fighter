﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_FIghter
{
    class Cat : Pet
    {

        public Cat(string name, string breed) : base(name, breed)
        {
        }

        public override string MakeNoise()
        {
            return "Meow, Zoomies";
        }
    }
}
