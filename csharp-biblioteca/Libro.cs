using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        // ATTRIBUTI
        public int NPagine { get; set; }

        // COSTRUTTORE
        public Libro(int nPagine, string titolo, int anno, string settore, string scaffale, string autore) : base(titolo, anno, settore, scaffale, autore)
        {
            this.NPagine = nPagine;
        }

        // METODI
        //Metodo per stampare a schermo le informazioni del libro
        public override void StampaInfoDocumento()
        {
            base.StampaInfoDocumento();
            Console.WriteLine($"- Numero di pagine: {this.NPagine}");
        }
    }
}
