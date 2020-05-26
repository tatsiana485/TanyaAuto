using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Warrior
       
        {
          public string Name { get; set; }
          public int Health { get; set; }
          

          public Warrior(string name, int health)
          {
            Name = name;
            Health = health;
          }

        public virtual void GetDamage(int damage)
        {
           Health = Health - damage;
        }

    }


    
}
