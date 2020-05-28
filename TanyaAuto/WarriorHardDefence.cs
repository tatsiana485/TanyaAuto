using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class WarriorHardDefence : Warrior
   
    {
        public int GetDamageHard { get; set; }
        public float RatioHard = 0.5f;

        public WarriorHardDefence(string name, int health) : base(name, health)
        {
        }
        public override void GetDamage(int damage)
        {
            Health = Health - (int)(damage * RatioHard);
            if (Health > 0)
            {
                IsAlive = true;
            }
            else
            {
                IsAlive = false;
            }
            if (Health < 0)
            {
                Health = 0;
            }

        }
    }
}

    

