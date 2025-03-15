using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfAcesso
{
    public class Usuario
    {

        public Usuario(int codigo, string? login, string? senha, DateTime? dataCadastro)
        {
            Codigo = codigo;
            Login = login;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

        public Usuario() { }

        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataCadastro { get; set; }

        public static List<Usuario> listaUsuario = new List<Usuario>();
    }
}
