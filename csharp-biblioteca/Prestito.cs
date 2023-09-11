using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        // ATTRIBUTI
        public DateTime InizioPrestito {  get; set; }
        public DateTime FinePrestito { get; set; }
        public Documento Documento { get; set; }
        public Utente Utente { get; set; }

        // COSTRUTTORE
        public Prestito(DateTime inizioPrestito, DateTime finePrestito, Documento documento, Utente utente)
        {
            this.InizioPrestito = inizioPrestito;
            this.FinePrestito = finePrestito;
            this.Documento = documento;
            this.Utente = utente;
        }
    }
}
