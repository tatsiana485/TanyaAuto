using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class German : Human
    {
        public German(string name)
        {
            humanName = name;
            hello = "Hallo";
        }
        public override void sayHello() 
        {
            Console.WriteLine("Name: " + humanName + "// " + "Greeting is: " + hello);
        }
    }
}
