using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Cube : SolidShape
    {
        private double a;
        public Cube()
        {
            this.a = 1;
            this.area = CalculateArea();
            this.volume = CalculateVolume();
        }
        public Cube(double a)
        {
            this.a = a;
            this.area = CalculateArea();
            this.volume = CalculateVolume();
        }

        public override double CalculateArea()
        {
            this.area = 6 * Math.Pow(a, 2);
            return area;
        }

        public override double CalculateVolume()
        {
            this.volume = Math.Pow(a, 3);
            return volume;
        }

    }
}
