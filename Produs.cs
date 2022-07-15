using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_incercarea_2
{
    [Serializable]
   public  class Produs
    {
        private string cod_produs;
        private string denumire;
        private int nr_buc_stoc;
        private double pret;

        public string Cod_produs
        {
            get { return cod_produs; }
            set
            {
                if (value != null)
                    cod_produs = value;
            }
        }
        public string Denumire
        {
            get { return denumire; }
            set
            {
                if (value.Length > 2)
                    denumire = value;
            }
        }

        public int Nr_buc_stoc
        {
            get { return nr_buc_stoc; }
            set { nr_buc_stoc = value; }
        }

        public double Pret
        {
            get { return pret; }
            set
            {
                if (value > 3)
                    pret = value;
            }
        }
        public Produs(string cod, string den, int nr, double p)
        {
            cod_produs = cod;
            denumire = den;
            nr_buc_stoc = nr;
            pret = p;
        }
        public Produs()
        {
            //cod_produs = null;
            //denumire = " unknown";
            //nr_buc_stoc = 0;
            //pret = 0; 
        }
    }

}

