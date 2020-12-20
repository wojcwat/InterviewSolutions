using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class VolumeComparer : IFigureComparer
    {
        public int Compare(object obj1, object obj2)
        {
            SolidShape s1 = (SolidShape)obj1;
            SolidShape s2 = (SolidShape)obj2;

            if (s1.GetVolume() < s2.GetVolume())
            {
                return 1;
            }
            else if (s1.GetVolume() > s2.GetVolume())
            {
                return -1;
            }
            else if (s1.GetVolume() == s2.GetVolume())
                return 0;
            else
                return 404;

        }

    }
}
