using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Tester3
    {
        public void Test()
        {
            var areaComparer = new AreaComparer();
            var result = areaComparer.Compare(new Square(30), new Cube(30));
            Console.WriteLine(result);
            var result2 = areaComparer.Compare(new Square(20), new Square(20));
            Console.WriteLine(result2);
            var volumeComparer = new VolumeComparer();
            var result3 = volumeComparer.Compare(new Sphere(20), new Cube(30));
            Console.WriteLine(result3);
        }
    }
}
