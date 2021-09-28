using System;

namespace Geometic_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square()
            {
                Side1 = 5
            };
            var r1 = new Rect()
            {
                Side1 = 3, Side2 = 5
            };
            var q1 = new Quad()
            {
                Side1 = 3, Side2 = 4, Side3 = 5, Side4 =6
            };
            Console.WriteLine($"Perimeter for Quad is {q1.Perimeter()}");
            Console.WriteLine($"Perimeter for Rect is {r1.Perimeter()}");
            Console.WriteLine($"Area for Rect is {r1.Area()}");
            Console.WriteLine($"Perimeter for Square is {s1.Perimeter()}");
            Console.WriteLine($"Area for Square is {s1.Area()}");

        }
    }
}
