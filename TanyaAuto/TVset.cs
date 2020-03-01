using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class TVset
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0 || value > 100)
                    volume = value;
                else volume = 0;
            }
        }
    }
}

