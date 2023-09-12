using csharp_biblioteca;

Biblioteca biblioteca1 = new Biblioteca();

// Creo qualche documento per provare
Libro libro1 = new Libro(431, "Clean Code", 2008, "informatica", "12A", "Robert C. Martin");
Libro libro2 = new Libro(272, "Il ritratto di Dorian Grey", 1890, "storico", "8B", "Oscar Wilde");
Dvd dvd1 = new Dvd(86, "Quo Vado?", 2015, "comico", "1A", "Gennaro Nunziante");
Dvd dvd2 = new Dvd(149, "Revenant", 2015, "storico", "3A", "Alejandro Gonzalez Inarritu");

// Aggiungo i documenti alla biblioteca
biblioteca1.AggiungiDocumento(libro1);
biblioteca1.AggiungiDocumento(libro2);
biblioteca1.AggiungiDocumento(dvd1);
biblioteca1.AggiungiDocumento(dvd2);

// Test stampa documenti
List<Documento> test = new List<Documento>();
test.Add(libro1);
test.Add(libro2);
test.Add(dvd1);
test.Add(dvd2);
Console.WriteLine("I DOCUMENTI REGISTRATI SONO: ");
foreach (Documento documento in test)
{
    documento.StampaInfoDocumento();
}

// Creo un utente
Utente utente1 = new Utente("Rinaldi", "Marco", "marcorinaldi98@libero.it", "testtest", 3516416665);

// test stampa utente
utente1.StampaInfoUtente();

// Aggiungo l'utente alla biblioteca
biblioteca1.AggiungiUtente(utente1);

// Registro un prestito
biblioteca1.RegistraPrestito(libro1, utente1, DateTime.Now, DateTime.Now.AddDays(7));

// Cerco documento per codice
Documento documentoCercato = biblioteca1.CercaDocumentoPerCodice(libro1.Codice);
if (documentoCercato != null)
{
    Console.WriteLine("Documento trovato: " + documentoCercato.Titolo);
}
else
{
    Console.WriteLine("Documento non trovato.");
}

// Cerco documento per titolo
List<Documento> documentiTrovati = biblioteca1.CercaDocumentoPerTitolo("Clean Code");
foreach (var doc in documentiTrovati)
{
    Console.WriteLine("Documento trovato: " + doc.Titolo);
}

// Cerco il prestito in base al nome e cognome dell'utente
List<Prestito> prestitiUtente = biblioteca1.CercaPrestitiPerUtente("Marco", "Rinaldi");
foreach (var prestito in prestitiUtente)
{
    Console.WriteLine("Prestito di " + prestito.Documento.Titolo + " a " + prestito.Utente.Nome + " " + prestito.Utente.Cognome);
}
