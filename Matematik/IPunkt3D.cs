using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IPunkt3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    class Punkt3D : IPunkt3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Punkt3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
