using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Varrior
    {
        public int LivesQuantity { get; set; }
        public string Name { get; set; }

        public Varrior (string name, int lives)
        {
            Name = name;
            LivesQuantity = lives;
        }

        public virtual void Received_Damage()
        {
            Console.WriteLine("The name of the varrior: " + Name + " Quantity of lifes: " + LivesQuantity);
        }

    }
}
