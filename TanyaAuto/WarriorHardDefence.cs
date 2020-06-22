using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class WarriorHardDefence : Warrior
   
    {
        public int GetDamageHard { get; set; }
        public float ratioHard = 0.5f;

        public WarriorHardDefence(string name, int health) : base(name, health)
        {
        }
        public override void getDamage(int damage)
        {
            warriorHealth = warriorHealth - (int)(damage * ratioHard);
            if (warriorHealth > 0)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
            if (warriorHealth < 0)
            {
                warriorHealth = 0;
            }

        }
    }
}


    

