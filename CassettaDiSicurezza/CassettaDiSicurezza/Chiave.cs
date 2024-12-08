using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class Chiave : OggettoSegreto
    {
        public string Tipo { get; set; }

        public Chiave(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            Tipo = tipo;
            CalcolaValoreAssicurato();
        }

        public override void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato * 1000;
        }
    }
}
