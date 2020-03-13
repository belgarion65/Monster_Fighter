using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_FIghter
{
    class Weapon : Item
    {
        private int attackPower;

        public Weapon(string type, string name, int attackPower) : base(type, name)
        {
            this.attackPower = attackPower;
        }

        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }
    }
}
