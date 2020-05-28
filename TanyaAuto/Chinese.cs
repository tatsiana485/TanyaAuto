using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Chinese : Human
        
    {
        
        public Chinese (string name)
        {
            Name = name;
            Hello = "Komichiva";

        }
        public override void SayHello()
        {
            Console.WriteLine("Name: " + Name + "// " + "Greeting is: " + Hello);
        }

    }
    
    
}
