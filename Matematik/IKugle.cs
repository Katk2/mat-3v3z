using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IKugle
    {
        public IPunkt3D Centrum { get; set; }
        public double Radius { get; set; }
        public double Rumfang { get; set; }

        public bool ErPunktPåKugleOverflade(IPunkt3D punkt);
        public double BeregnRumfang();

        public double BeregnOverfladeAreal();
        public double BeregnVolumeAfKuglekalot(double h);
        public double BeregnKrumOverfladearealAfKuglekalot(double a, double h);
        public double BeregnOverfladearealAfKuglekalot(double h);
    }

    class Kugle : IKugle
    {
        public IPunkt3D Centrum { get; set; }
        public double Radius { get; set; }
        public double Rumfang { get; set; }
        
        public Kugle(IPunkt3D centrum, double radius)
        {
            Centrum = centrum;
            Radius = radius;
            Rumfang = BeregnRumfang();
        }
        public double BeregnKrumOverfladearealAfKuglekalot(double a, double h)
        {
            return Math.PI * (a * a + h * h);
        }

        public double BeregnOverfladeAreal()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double BeregnOverfladearealAfKuglekalot(double h)
        {
            return Math.PI * h * (4 * Radius - h);
        }

        public double BeregnRumfang()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }

        public double BeregnVolumeAfKuglekalot(double h)
        {
            return Math.PI / 3 * h * h * (3 * Radius - h);
        }

        public bool ErPunktPåKugleOverflade(IPunkt3D punkt)
        {
            return Math.Pow(punkt.X - Centrum.X, 2) + Math.Pow(punkt.Y - Centrum.Y, 2) + Math.Pow(punkt.Z - Centrum.Z, 2) == Math.Pow(Radius, 2);
        }
    }
}
