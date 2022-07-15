using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_incercarea_2
{
    public class Client
    {
        private string nume;
        private string prenume;
        private string telefon;
        private string adresa;

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length > 2)
                    nume = value;
            }
        }
        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value.Length > 2)
                    prenume = value;
            }
        }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (value.Length > 10)
                    telefon = value;
            }
        }
        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value != null)
                    adresa = value;
            }
        }
        public Client(string n, string p, string t, string a)
        {
            nume = n;
            prenume = p;
            telefon = t;
            adresa = a;
        }
    }
}
