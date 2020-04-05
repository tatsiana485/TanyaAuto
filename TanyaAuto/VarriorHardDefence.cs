using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class VarriorHardDefence : Varrior
    {
        public int Received_Damage_Hard { get; set; }

        public VarriorHardDefence(string name, int lives, int damage_hard) : base(name, lives)
        {
            this.Received_Damage_Hard = damage_hard;
        }

        public override void Received_Damage()
        {
            base.Received_Damage();
            Console.WriteLine("Damage of hard defence varrior " + Name +  " - Quantity of Lives: " + LivesQuantity + " - Lives: " + Received_Damage_Hard);
        }
    }
}
