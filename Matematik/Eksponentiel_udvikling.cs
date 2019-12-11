using System;
using System.Collections.Generic;
using System.Text;


namespace Matematik
{
    class Eksponentiel_udvikling : IEksponentielUdvikling
    {
        public double A { get; set; }
        public double B { get; set; }
        public double R { get; set; }

        public Eksponentiel_udvikling(double a, double b, double r)
        {
            A = a;
            B = b;
            R = r;
        }

        public double BestemFordoblingstid()
        {
            return Math.Log(2) / Math.Log(A);

        }

        public double BestemHalveringstid()
        {
            return Math.Log(0.5) / Math.Log(A);
        }

        public double BestemX(double y)
        {
            throw new NotImplementedException();
        }

        public void ForskriftUdFraToPunkter(IPunkt2D punkt1, IPunkt2D punkt2)
        {
            A = Math.Pow((punkt2.Y / punkt1.Y), (1 / punkt2.X - punkt1.X);
            B = punkt1.Y * Math.Pow(A, -punkt1.X);

        }

        public double Funktionsværdi(double x)
        {
            return B * Math.Pow(A,x);
        }

        public double Skæring(IEksponentielUdvikling eksponentielUdvikling)
        {
            throw new NotImplementedException();
        }
    }
}
