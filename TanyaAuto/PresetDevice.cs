using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class PresetDevice : ISwitchable
    { 
        public void SwitchOn()
            {
                Console.WriteLine("The Preset Device is currently working");
            }
            public void SwitchOff()
            {
                Console.WriteLine("The Preset Device is currently not working");
            }
        }
    }


