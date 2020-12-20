using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class AreaComparer : IFigureComparer
    {
        public int Compare(object obj1, object obj2)
        {
            try
            {
                Shape s1 = obj1 as Shape;
                Shape s2 = obj2 as Shape;
                if (s1.GetArea() < s2.GetArea())
                {
                    return 1;
                }
                if (s1.GetArea() > s2.GetArea())
                {
                    return -1;
                }
                else
                    return 0;
            }
            catch( NullReferenceException ex)
            {
                Console.WriteLine("Both objects must be of Shape type!");
                Console.WriteLine(ex.Message);
                return 404;
            }

 

        }
    }
}
