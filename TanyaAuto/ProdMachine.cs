using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class ProdMachine : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("The Production Machine is currently working");
        }

        public void SwitchOff()
        { 
            Console.WriteLine ("The Production Machine is currently not working");
        }
    }
}
