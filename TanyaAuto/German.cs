using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class German : Human

    {
        public German(string name)
            {
                Name = name;
                Hello = "Hallo";
                
            }
            public override void SayHello() 
            {
            Console.WriteLine("Name: " + Name + "// " + "Greeting is: " + Hello);
            }

    }
}
