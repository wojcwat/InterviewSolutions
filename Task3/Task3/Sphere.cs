using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Sphere : SolidShape    {
        private double radius;

        public Sphere()
        {
            radius = 1;
            this.area = CalculateArea();
            this.volume = CalculateVolume();
        }
        public Sphere(double radius)
        {
            this.radius = radius;
            this.area = CalculateArea();
            this.volume = CalculateVolume();
        }
        public override double CalculateArea()
        {
            this.area = 4 * Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public override double CalculateVolume()
        {
            this.volume = (4 * Math.PI * Math.Pow(radius, 3) / 3);
            return volume;
        }
    }
}
