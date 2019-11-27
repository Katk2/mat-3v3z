using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class Punkt2D : IPunkt2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double BeregnAfstandTilAndetPunkt(IPunkt2D punkt)
        {
            throw new NotImplementedException();
        }

        public double BeregnAfstandTilOrigo(IPunkt2D punkt)
        {
            throw new NotImplementedException();
        }
    }
}
