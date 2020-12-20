using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(10);
            Square sq2 = new Square(11);
            Circle cr = new Circle(2);
            Console.WriteLine(sq.CalculateArea());
            Console.WriteLine(sq2.CalculateArea());

            AreaComparer areaComparer = new AreaComparer();
            var result = areaComparer.Compare(sq2, sq);
            Console.WriteLine(result);

            VolumeComparer volumeComparer = new VolumeComparer();
            var result2 = volumeComparer.Compare(new Sphere(3), new Cube(4));

            Sphere s = new Sphere(3);
            Cube c = new Cube(4);
            Console.WriteLine(s.GetVolume());
            Console.WriteLine(c.GetVolume());
            Console.WriteLine(result2);
        }
    }
}
