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


        public Institution(string name, string arbeit, string länder, string tätigkeit, string dzi, string finanzen, string konto)
        {
            Name = name;
            Arbeit = arbeit;
            Länder = länder;
            Tätigkeit = tätigkeit;
            Dzi = dzi;
            Finanzen = finanzen;
            Konto = konto;
        }

    }
}
