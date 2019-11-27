using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IPotensudvikling
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Funktionsværdi(double x);
        public double BestemX(double y);
        public void ForskriftUdFraToPunkter(IPunkt2D punkt1, IPunkt2D punkt2);

    }
}
