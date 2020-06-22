using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    abstract class Human
    {
        public string humanName { get; set; }
        public string hello { get; protected set; }
        public abstract void sayHello();
       
    }
}
