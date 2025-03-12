using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS01_CadastroContato
{
    public class Contato
    {
        public Contato(string? nome, string? sobrenome, string? telefone, string? telefoneChar, string? email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            TelefoneChar = telefoneChar;
            Email = email;
        }

        public Contato() 
        { 
        
        }

        public static List<Contato> CadastroContato = new List<Contato>();

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public string? TelefoneChar { get; set; }
        public string? Email { get; set; }

    }
}
