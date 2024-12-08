using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class Gioiello : OggettoSegreto
    {
        public string Tipo { get; set; }

        public Gioiello(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            Tipo = tipo;
            CalcolaValoreAssicurato();
        }

        public override void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato * 5;
        }
    }
}
