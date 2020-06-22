using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Warrior
    {
        public string warriorName { get; set; }
        public int warriorHealth { get; set; }
        
        public bool isAlive;

        public Warrior(string name, int health)
        {
            warriorName = name;
            warriorHealth = health;
        }

        public virtual void getDamage(int damage)
        {
            warriorHealth = warriorHealth - damage;

            if (warriorHealth <= 0)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }
            if (warriorHealth < 0)
            {
                warriorHealth = 0;
            }
        }
    }     
}
