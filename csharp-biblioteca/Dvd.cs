using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Documento
    {
        // ATTRIBUTI
        public int Durata { get; set; }

        // COSTRUTTORE
        public Dvd(int durata, string titolo, int anno, string settore, string scaffale, string autore) : base(titolo, anno, settore, scaffale, autore)
        {
            this.Durata = durata;
        }

        // METODI
        //Metodo per stampare a schermo le informazioni del dvd
        public override void StampaInfoDocumento()
        {
            base.StampaInfoDocumento();
            Console.WriteLine($"- Durata: {this.Durata} minuti");
        }
    }
}
