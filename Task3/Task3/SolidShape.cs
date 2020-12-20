using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class SolidShape : Shape,IAreaShape,IVolumeShape
    {
        protected double volume;

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        public double GetVolume()
        {
            return volume;
        }
    }
}
