using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Chinese : Human        
    {
        public Chinese (string name)
        {
            humanName = name;
            hello = "Nihao";
        }
        public override void sayHello()
        {
            Console.WriteLine("Name: " + humanName + "// " + "Greeting is: " + hello);
        }
    }
}
