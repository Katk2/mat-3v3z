using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IPunkt2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double BeregnAfstandTilAndetPunkt(IPunkt2D punkt);
        public double BeregnAfstandTilOrigo(IPunkt2D punkt);


    }
}
