using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IBinomialfordeling
    {
        public int Antalsparameter { get; set; }
        public double Sandsynlighedsparameter { get; set; }

        public double BeregnPunktsandsynlighed(int successer);

        public double BeregnAkkummuleretSandsynlighed(int successer);

        public double BeregnSandsynlighedForAtFåMellem(int start, int slut);

        public string UdskrivSandsynlighedstabel();
    }
}
