using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozo(string sor)
        {
            string[] d = sor.Split(';');
            Nev = d[0];
            Nem = d[1] == "férfi";
            Reszleg = d[2];
            Belepes = int.Parse(d[3]);
            Ber = int.Parse(d[4]);
        }

        public override string ToString()
        {
            return $"Név: {Nev}\nNem: {Nem}\nRészleg: {Reszleg}\nBelépés: {Belepes}\nBér: {Ber}";
        }
    }

  
}
