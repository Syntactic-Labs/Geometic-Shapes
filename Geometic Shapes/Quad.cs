using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometic_Shapes
{
    class Quad
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public int Perimeter()      // The () makes it a method
        {
            return Side1 + Side2 + Side3 + Side4;
        }

    }
}
