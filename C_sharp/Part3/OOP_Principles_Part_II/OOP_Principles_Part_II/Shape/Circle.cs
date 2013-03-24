using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeScore
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.Width = radius;
            this.Height = radius;
        }

        public int Radius
        {
            get { return this.radius; }
            set
            {
                this.radius = value;
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Height;
        }
    }
}
