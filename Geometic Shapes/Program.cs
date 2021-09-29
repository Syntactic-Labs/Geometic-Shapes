using System;

namespace Geometic_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            var q1 = new Quad(5, 5, 5, 5);

            var r1 = new Rect(3, 7);    //utalizing Capsulation

            var s1 = new Square(5);
            
            
            q1.Print();
            r1.Print();
            s1.Print();

        }
    }
}
