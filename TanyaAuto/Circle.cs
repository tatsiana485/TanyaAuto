using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{

    class Circle : Geometry
    {
        public int Radius { get; set; }
        public Circle(int Radius, int x, int y) : base(x, y)
        {
            this.Radius = Radius;
        }
        public void DrawingCircle()
        {
            Console.WriteLine("Drawing the Circle");
        }
    }
}
