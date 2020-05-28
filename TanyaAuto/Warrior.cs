using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Warrior

    {
        public string Name { get; set; }
        public int Health { get; set; }

        public bool IsAlive;


        public Warrior(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public virtual void GetDamage(int damage)
        {
            Health = Health - damage;

            if (Health <= 0)
            {
                IsAlive = false;
            }
            else
            {
                IsAlive = true;
            }
            if (Health < 0)
            {
                Health = 0;
            }


        }


    }

        
}
