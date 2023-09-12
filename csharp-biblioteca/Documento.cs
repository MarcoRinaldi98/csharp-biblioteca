using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        // ATTRIBUTI
        public string Codice {  get; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

        // COSTRUTTORE
        public Documento(string titolo, int anno, string settore, string scaffale, string autore) 
        { 
            this.Codice = GeneraCodiceRandom();
            this.Titolo = titolo;
            this.Anno = anno;               
            this.Settore = settore;
            this.Scaffale = scaffale;
            this.Autore = autore;
            
        }

        // METODI
        //Metodo per generare un codice random
        private string GeneraCodiceRandom()
        {
            Random randomNumber = new Random();
            return "#B" + randomNumber.Next(1, 10000);
        }
        //Metodo per stampare a schermo le informazioni del documento
        public virtual void StampaInfoDocumento()
        {
            Console.WriteLine($@"
Documento {this.Codice}:
- Titolo: {this.Titolo}
- Anno: {this.Autore}
- Settore: {this.Settore}
- Scaffale: {this.Scaffale}
- Autore: {this.Autore}");
        }
    }
}
