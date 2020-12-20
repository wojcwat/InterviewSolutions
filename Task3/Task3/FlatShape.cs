using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class FlatShape : Shape, IAreaShape
    {

        public abstract double CalculateArea();
        
    }
}
