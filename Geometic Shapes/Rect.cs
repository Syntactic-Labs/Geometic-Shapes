﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometic_Shapes
{
    class Rect : Quad
    {
        public new void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()} Area: {Area()}");
        }
        public int Area()
        {
            return Side1 * Side2;
        }
        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB) 
        { 
        }    //This can be done in Quad
    }
}
