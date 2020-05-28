using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Russian : Human
    {
        
        public Russian(string name)
        {
            Name = name;
            Hello = "Privet";

        }
        public override void SayHello()
        {
            Console.WriteLine("Name: " + Name + "// " + "Greeting is: " + Hello);
        }

    }
}


    

