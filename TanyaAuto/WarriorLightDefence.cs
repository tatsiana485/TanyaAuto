using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class WarriorLightDefence : Warrior
    //{

    {
        public int GetDamageLight { get; set; }
        public float RatioLight = 5f;
        

        public WarriorLightDefence(string name, int health) : base(name, health)
        {
            
        }
        public override void GetDamage(int damage)
        {
           Health = Health - (int)(damage * RatioLight);
        }
    }
}

