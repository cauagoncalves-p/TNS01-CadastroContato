using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFUsandoListagem
{
    public class Usuario
    {

      

        

        public Usuario(string? login, string? senha, string? confirmarSenha, DateTime? dataCadastro)
        {
            Login = login;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
            DataCadastro = dataCadastro;
        }

        public Usuario() { }

        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? ConfirmarSenha { get; set; }
        public DateTime? DataCadastro { get; set; }

        public static List<Usuario> listaUsuario = new List<Usuario>();
    }
}
