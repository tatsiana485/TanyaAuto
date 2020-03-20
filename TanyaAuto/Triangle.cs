using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Triangle : Geometry
    {
        public int Angle { get; set; }
        public Triangle(int Angle, int x, int y) : base(x, y)
        {
            this.Angle = Angle;
        }
        public void DrawingTriangle()
        {
            Console.WriteLine("Drawing the Triangle");
        }
    }
}
