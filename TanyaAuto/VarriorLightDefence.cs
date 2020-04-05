using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class VarriorLightDefence : Varrior
    {
        public int Received_Damage_Light { get; set; } 

        public VarriorLightDefence(string name, int lives, int damage_light) : base (name, lives)
        {
            this.Received_Damage_Light = damage_light;
        }

        public override void Received_Damage()
        {
            base.Received_Damage();
            Console.WriteLine("Damage of light defence varrior " + Name +  " - Quantity of Lives: " + LivesQuantity + " - Lives: " + Received_Damage_Light);
        }
    }
}
