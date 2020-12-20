using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Square : FlatShape
    {
        private double a;
        public Square()
        {
            this.a = 1;
            this.area = CalculateArea();
        }
        public Square(double a)
        {
            this.a = a;
            this.area = CalculateArea();
        }
        public override double CalculateArea()
        {
            this.area = Math.Pow(a, 2);
            return area;
        }
    }
}
