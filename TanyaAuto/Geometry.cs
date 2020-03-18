using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Geometry
    {
        public int x { get; set; } //coordinate 1
        public int y { get; set; } // coordinate 2
        public Geometry(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Circle : Geometry
    {
        public int radius { get; set; }
        public Circle(int radius, int x, int y) : base(x, y)
        {
            this.radius = radius;
        }
        public void DrawingCircle()
        {
            //drawing mechanism ja ne umeju
        }
    }
    class Triange : Geometry
    {
        public int angle { get; set; }
        public Triange(int angle, int x, int y) : base(x, y)
        {
            this.angle = angle;
        }
        public void DrawingTriangle()
        {
            //drawing mechanism ja ne umeju
        }

    }
}

