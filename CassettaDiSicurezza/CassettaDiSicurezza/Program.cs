using CassettaDiSicurezza;

class Program
{
    static void Main(string[] args)
    {
        // Creazione cassette di sicurezza
        CassettaSicurezza cassetta1 = new CassettaSicurezza("001", "Gunnebo", "1234", "11111");
        CassettaSicurezza cassetta2 = new CassettaSicurezza("002", "Gunnebo", "1234", "22222");
        CassettaSicurezza cassetta3 = new CassettaSicurezza("003", "Gunnebo", "1234", "33333");

        // Oggetti da inserire
        cassetta1.InserisciOggetto(new Gioiello("G1", 1000, "Collana"), "11111");
        cassetta2.InserisciOggetto(new DocumentoLegale("D1", 80, "Testamento"), "22222");
        cassetta3.InserisciOggetto(new Chiave("K1", 10, "Fisica"), "33333");

        // Creazione cassette speciali
        CassettaSpeciale speciale1 = new CassettaSpeciale("S001", "Gunnebo", "1234", "44444");
        CassettaSpeciale speciale2 = new CassettaSpeciale("S002", "Gunnebo", "1234", "55555");
        CassettaSpeciale speciale3 = new CassettaSpeciale("S003", "Gunnebo", "1234", "66666");

        // Trasferimento oggetti
        speciale1.InserisciOggetto(cassetta1.RimuoviOggetto("11111"), "44444");
        speciale2.InserisciOggetto(cassetta2.RimuoviOggetto("22222"), "55555");
        speciale3.InserisciOggetto(cassetta3.RimuoviOggetto("33333"), "66666");


        Console.WriteLine($"Cassetta Speciale 1: Valore Assicurato {speciale1.CalcolaValoreAssicuratoSpeciale()}");
        Console.WriteLine($"Cassetta Speciale 2: Valore Assicurato {speciale2.CalcolaValoreAssicuratoSpeciale()}");
        Console.WriteLine($"Cassetta Speciale 3: Valore Assicurato {speciale3.CalcolaValoreAssicuratoSpeciale()}");
    }
}
