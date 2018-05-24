using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationStation
{
    public class Institution
    {
       

        public string Name { get; set; }
        public string Arbeit { get; set; }
        public string Länder { get; set; }
        public string Tätigkeit { get; set; }
        public string Dzi { get; set; }
        public string Finanzen { get; set; }
        public string Konto { get; set; }


        public Institution()
        {
            Name = "Name";
            Arbeit = "ArbeitsSchwerpunkte";
            Länder = "Laender";
            Tätigkeit = "Taetigkeit";
            Dzi = "Dzi";
            Finanzen = "Anteil" ;
            Konto = "SpendenKonto";
        }

    }
}
