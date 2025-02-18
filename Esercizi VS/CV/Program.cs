using CV.Models;

class Program
{
    static void Main()
    {
        Cv cv = new Cv();
        Console.WriteLine("digitare nome, cognome, email e tell.");
        var risposta = Console.ReadLine();
        cv.informazioniPersonali.nome = risposta;
        risposta = Console.ReadLine();
        cv.informazioniPersonali.cognome = risposta;
        risposta = Console.ReadLine();
        cv.informazioniPersonali.email = risposta;
        risposta = Console.ReadLine();
        cv.informazioniPersonali.telefono = risposta;
        Console.WriteLine("Che studi ha frequentato? Tipo; istututo; qualifica; dal; al.");
        risposta = Console.ReadLine();
        cv.studiEffettuati.tipo = risposta;
        risposta = Console.ReadLine();
        cv.studiEffettuati.istututo = risposta;
        risposta = Console.ReadLine();
        cv.studiEffettuati.qualifica = risposta;

        DateTime valore;
        while (true)
        {
            Console.WriteLine("Inserisci dal (gg/MM/yyyy):");
            string inp = Console.ReadLine();

            if (DateTime.TryParseExact(inp, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out valore))
                break;

            Console.WriteLine("Formato non valido. Riprova.");
        }
        cv.studiEffettuati.dal = valore;

        while (true)
        {
            Console.WriteLine("Al (gg/MM/yyyy):");
            string inp = Console.ReadLine();

            if (DateTime.TryParseExact(inp, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out valore))
                break;

            Console.WriteLine("Formato non valido. Riprova.");
        }
        cv.studiEffettuati.al = valore;

        bool continua = true;
        while (continua)
        {
            Esperienze nuovaEsperienza = new Esperienze();

            Console.Write("Inserisci il nome dell'azienda: ");
            nuovaEsperienza.azienda = Console.ReadLine();

            Console.Write("Inserisci il Job Title: ");
            nuovaEsperienza.jobTitle = Console.ReadLine();

            Console.Write("Inserisci la data di inizio (es: 01/01/2020): ");
            nuovaEsperienza.dal = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci la data di fine (es: 31/12/2023, lascia vuoto se ancora in corso): ");
            string dataFine = Console.ReadLine();
            nuovaEsperienza.al = string.IsNullOrWhiteSpace(dataFine) ? DateTime.Now : DateTime.Parse(dataFine);

            Console.Write("Descrizione dell'esperienza: ");
            nuovaEsperienza.descrizione = Console.ReadLine();

            Console.Write("Compiti svolti: ");
            nuovaEsperienza.compiti = Console.ReadLine();

            // Aggiungiamo l'esperienza alla lista
            cv.impieghi.esperienze.Add(nuovaEsperienza);

            // Chiediamo se vuole aggiungere un'altra esperienza
            Console.Write("Vuoi aggiungere un'altra esperienza? (s/n): ");
            continua = Console.ReadLine().ToLower() == "s";
        }
        Console.WriteLine("========================");
        Console.WriteLine("Risultati:");
        Console.WriteLine($"Cv di {cv.informazioniPersonali.nome} ");
        Console.WriteLine($"+++Inizio formazioni personali+++");
        Console.WriteLine($"Nome:{cv.informazioniPersonali.nome}");
        Console.WriteLine($"Cognome:{cv.informazioniPersonali.cognome}");
        Console.WriteLine($"Email:{cv.informazioniPersonali.email}");
        Console.WriteLine($"Cell.:{cv.informazioniPersonali.telefono}");
        Console.WriteLine($"+++Fine formazioni personali+++");
        Console.WriteLine($"");
        Console.WriteLine($"+++Inizio Studi e Formazione+++");
        Console.WriteLine($"Istituto:{cv.studiEffettuati.istututo}");
        Console.WriteLine($"Qualifica:{cv.studiEffettuati.qualifica}");
        Console.WriteLine($"Tipo:{cv.studiEffettuati.tipo}");
        Console.WriteLine($"Dal {cv.studiEffettuati.dal} al {cv.studiEffettuati.al}");
        Console.WriteLine($"");
        Console.WriteLine($"+++Fine Studi e Formazione+++");
        Console.WriteLine($"");
        Console.WriteLine($"+++Inizio esperienze professionali+++");
        foreach (var esperienza in cv.impieghi.esperienze)
        {
            Console.WriteLine($"\nPresso:{esperienza.azienda}");
            Console.WriteLine($"Tipo di lavoro:{esperienza.jobTitle}");
            Console.WriteLine($"Compiti: {esperienza.compiti}");
            Console.WriteLine($"Dal: {esperienza.dal:d} Al: {(esperienza.al == DateTime.Now ? "Ancora in corso" : esperienza.al.ToString("dd/MM/yyyy"))}");
            Console.WriteLine($"Descrizione: {esperienza.descrizione}");
            Console.WriteLine($"");
            Console.WriteLine("+++Fine esperienze professionali+++");
            Console.ReadLine();
        }
    }
}