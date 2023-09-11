using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        // ATTRIBUTI
        public List<Documento> listaDocumenti = new List<Documento>();
        public List<Utente> listaUtenti = new List<Utente>();
        public List<Prestito> listaPrestiti = new List<Prestito>();

        // METODI
        // Metodo per aggiungere un documento alla biblioteca
        public void AggiungiDocumento(Documento documento)
        {
            listaDocumenti.Add(documento);
        }

        // Metodo per aggiungere un utente alla biblioteca
        public void AggiungiUtente(Utente utente)
        {
            listaUtenti.Add(utente);
        }

        // Metodo per registrare un prestito
        public void RegistraPrestito(Documento documento, Utente utente, DateTime inizioPrestito, DateTime finePrestito)
        {
            Prestito prestito = new Prestito
            {
                Documento = documento,
                Utente = utente,
                InizioPrestito = inizioPrestito,
                FinePrestito = finePrestito
            };
            listaPrestiti.Add(prestito);
        }
        // Metodo per cercare un documento per codice
        public Documento CercaDocumentoPerCodice(string codice)
        {
            return listaDocumenti.Find(doc => doc.Codice == codice);
        }

        // Metodo per cercare un documento per titolo
        public List<Documento> CercaDocumentoPerTitolo(string titolo)
        {
            return listaDocumenti.FindAll(doc => doc.Titolo.Contains(titolo));
        }

        // Metodo per cercare prestiti dato il nome e il cognome di un utente
        public List<Prestito> CercaPrestitiPerUtente(string nome, string cognome)
        {
            return listaPrestiti.FindAll(prestito => prestito.Utente.Nome == nome && prestito.Utente.Cognome == cognome);
        }
    }
}
