using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class OggettoSegreto
    {
        public string Id { get; set; }
        public double ValoreDichiarato { get; set; }
        public double ValoreAssicurato { get; protected set; }

        public OggettoSegreto(string id, double valoreDichiarato)
        {
            Id = id;
            ValoreDichiarato = valoreDichiarato;
        }

        public virtual void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato;
        }
    }
}
