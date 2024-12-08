using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    public class CassettaSicurezza
    {
        public string Seriale { get; set; }
        public string Produttore { get; set; }
        private string CodiceSblocco { get; set; }
        private string PIN { get; set; }
        public OggettoSegreto Oggetto { get; private set; }

        public CassettaSicurezza(string seriale, string produttore, string codiceSblocco, string pin)
        {
            Seriale = seriale;
            Produttore = produttore;
            CodiceSblocco = codiceSblocco;
            PIN = pin;
        }

        public bool Vuota()
        {
            return Oggetto == null;
        }

        public void InserisciOggetto(OggettoSegreto oggetto, string pin)
        {
            if (PIN != pin)
            {
                Console.WriteLine("Errore: PIN errato!");
            }
            if (Oggetto != null)
            {
                Console.WriteLine("Errore: Cassetta già occupata!");
            }
            Oggetto = oggetto;
        }

        public OggettoSegreto RimuoviOggetto(string pin)
        {
            if (PIN != pin)
            {
                Console.WriteLine("Errore: PIN errato!");
            }
            OggettoSegreto oggetto = Oggetto;
            return oggetto;
        }

        public void ModificaPIN(string nuovoPIN, string codiceSblocco)
        {
            if (CodiceSblocco != codiceSblocco)
            {
                Console.WriteLine("Errore: Codice di sblocco errato.");
            }
            PIN = nuovoPIN;
        }
    }
}
