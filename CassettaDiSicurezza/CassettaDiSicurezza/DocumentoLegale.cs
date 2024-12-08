using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class DocumentoLegale : OggettoSegreto
    {
        public string Tipo { get; set; }

        public DocumentoLegale(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            Tipo = tipo;
            CalcolaValoreAssicurato();
        }

        public override void CalcolaValoreAssicurato()
        {
            if (ValoreDichiarato >= 100)
            {
                ValoreAssicurato = ValoreDichiarato;
            }
            else
            {
                ValoreAssicurato = 50;
            }
        }
    }
}
