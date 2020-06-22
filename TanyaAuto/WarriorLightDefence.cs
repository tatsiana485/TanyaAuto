using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class WarriorLightDefence : Warrior
    {
        public int getDamageLight { get; set; }
        public float ratioLight = 5f;
        
        public WarriorLightDefence(string name, int health) : base(name, health)
        {
        }
        public override void getDamage(int damage)
        {
           warriorHealth = warriorHealth - (int)(damage * ratioLight);
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

