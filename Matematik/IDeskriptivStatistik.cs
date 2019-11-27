using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IDeskriptivStatistik
    {
        public List<double> Observationer { get; set; }
        public List<IObservation> UnikkeObservationer { get; set; }
        public double Gennemsnit { get; set; }
        public double Mindsteværdi { get; set; }
        public IObservation NedreKvartil { get; set; }
        public IObservation Median { get; set; }
        public IObservation ØvreKvartil { get; set; }
        public double Variationsbredde { get; set; }
        public double Varians { get; set; }
        public double Spredning { get; set; }
        public double Kvartilafstand { get; set; }


        public void BestemMindsteværdi();
        public void BestemStørsteværdi();
        public void BeregnGennemsnit();
        public void BeregnVariationsbredde();
        public void BeregnHyppigheder();
        public void BeregnFrekvenser();
        public void BeregnSummeredeFrekvenser();

        public void BestemTypetal();
        public void BestemFraktil(double fraktil);
        public void BeregnKvartilafstand();
        public void BeregnVarians();
        public void BeregnSpredning();

    }

    public interface IObservation
    {
        public double Observation { get; set; }
        public double Hyppighed { get; set; }
        public double Frekvens { get; set; }
        public double SummeretFrekvens { get; set; }
    }
}
