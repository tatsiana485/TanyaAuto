using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Russian : Human
    {
        public Russian(string name)
        {
            humanName = name;
            hello = "Privet";
        }
        public override void sayHello()
        {
            Console.WriteLine("Name: " + humanName + "// " + "Greeting is: " + hello);
        }
    }
}


    

