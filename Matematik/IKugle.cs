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
}
