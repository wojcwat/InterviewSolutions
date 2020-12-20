using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Circle : FlatShape
    {
        private double radius;
        public Circle()
        {
            this.radius = 1.0;
            this.area = CalculateArea();
        }

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            this.area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }
}
