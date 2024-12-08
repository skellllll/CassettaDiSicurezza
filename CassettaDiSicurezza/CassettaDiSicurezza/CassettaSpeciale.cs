using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class CassettaSpeciale : CassettaSicurezza
    {
        public CassettaSpeciale(string seriale, string produttore, string codiceSblocco, string pin) : base(seriale, produttore, codiceSblocco, pin)
        {

        }

        public double CalcolaValoreAssicuratoSpeciale()
        {
            if (Oggetto == null)
            {
                return 0;
            }

            if (Oggetto is Gioiello gioiello)
            {
                return gioiello.ValoreAssicurato * 0.9;
            }

            if (Oggetto is DocumentoLegale documento)
            {
                return documento.ValoreAssicurato * 0.8;
            }

            if (Oggetto is Chiave chiave)
            {
                return chiave.ValoreAssicurato * 0.7;
            }

            return Oggetto.ValoreAssicurato;
        }
    }
}
