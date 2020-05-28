using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Hello { get; protected set; }

        public abstract void SayHello();
       
    }
}
