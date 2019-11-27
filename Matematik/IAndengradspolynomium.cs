using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IAndengradspolynomium
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double Toppunkt { get; set; }
        public List<Punkt2D> Rødder { get; set; }

        public bool HarRødder();
        public void BeregnToppunkt();
        public List<Punkt2D> BeregnEvtRødder();

        public double BestemX(double y);





    }
}
