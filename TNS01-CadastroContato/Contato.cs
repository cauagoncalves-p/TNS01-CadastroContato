using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TNS01_CadastroContato.Contato;

namespace TNS01_CadastroContato
{
    public class Contato
    {
        public Contato(int codigo, string? nome, string? sobrenome, string? telefone, TipoTelefone? telefoneChar, string? email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            TelefoneChar = telefoneChar;
            Email = email;
            Codigo = codigo;
        }

        public Contato() 
        {
           

        }

        public enum TipoTelefone 
        {
            Pessoal = 1,
            Recado, 
            Comercial
        }

        public static List<Contato> CadastroContato = new List<Contato>();
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public TipoTelefone? TelefoneChar { get; set; }
        public string? Email { get; set; }

    }
}
