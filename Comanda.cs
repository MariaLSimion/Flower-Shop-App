using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_incercarea_2
{
   public class Comanda
    {
        public string nr_comanda;
        public DateTime data;
        public List<Produs> lista_p = new List<Produs>();
        public Client cli;
      
        public Comanda(string nr, DateTime d, List<Produs> p, Client c )
        {
            nr_comanda = nr;
            data = d;
            lista_p = p;
            cli = c;
        }
        
    }
}
