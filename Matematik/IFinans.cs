using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    interface IFinans
    {
        public double BeregnKapitalværdi(double startbeløb, double rente, double terminer);
        public double BeregnStartværdi(double slutbeløb, double rente, double terminer);
        public double BeregnRente(double startbeløb, double slutbeløb, double terminer);
        public double BeregnAntalTerminer(double startbeløb, double slutbeløb, double rente);
        public double BeregnEffektivRente(double årligNominelRente, double antalTerminerPerÅr);
        public double BeregnFremtidsværdiAfAnnuitet(double ydelse, double rente, double terminer);
        public double BeregnYdelseForFremtidsværdi(double fremtidsværdi, double rente, double terminer);
        public double BeregnAntalTerminerForFremtidsværdi(double fremtidsværdi, double ydelse, double rente);
        public double BeregnNutidsværdiAfAnnuitet(double ydelse, double rente, double terminer);
        public double BeregnYdelseForNutidsværdi(double nutidsværdi, double rente, double terminer);
        public double BeregnAntalTerminerForNutidsværdi(double nutidsværdi, double ydelse, double rente);


    }
}
