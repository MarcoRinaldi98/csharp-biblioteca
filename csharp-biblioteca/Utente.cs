using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        // ATTRIBUTI
        public string Cognome {  get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public uint Telefono { get; set; }

        // COSTRUTTORE
        public Utente(string cognome, string nome, string email, string password, uint telefono)
        {
            this.Cognome = cognome;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Telefono = telefono;
        }

        // METODI
        //Metodo per stampare a schermo le informazioni dell'utente
        public void StampaInfoUtente()
        {
            Console.WriteLine($@"
- Nome: {this.Nome}
- Cognome: {this.Cognome}
- Email: {this.Email}
- Password: {this.Password}
- Telefono: +39 {this.Telefono}");
        }
    }
}
