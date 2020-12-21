using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class VolumeComparer : IFigureComparer
    {
        //Returns -1 if first object has bigger volume, 1 if second, 0 if objects are equal
        public int Compare(object obj1, object obj2)
        {
            try
            {
                SolidShape s1 = obj1 as SolidShape;
                SolidShape s2 = obj2 as SolidShape;

                if (s1.GetVolume() < s2.GetVolume())
                {
                    return 1;
                }
                else if (s1.GetVolume() > s2.GetVolume())
                {
                    return -1;
                }
                else 
                    return 0;
                
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Both objects must be of SolidShape type!");
                Console.WriteLine(ex.Message);
                return 404;
            }


        }

    }
}
