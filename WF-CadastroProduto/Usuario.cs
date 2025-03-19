using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CadastroProduto
{
    public class Usuario
    {
        public Usuario(int codigo, string? login, string? senha, string? confirmarSenha, DateTime? dataCadastro)
        {
            Codigo = Codigo;
            Login = login;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
            DataCadastro = dataCadastro;
        }

        public Usuario() { }
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public string? ConfirmarSenha { get; set; }
        public DateTime? DataCadastro { get; set; }

        public static List<Usuario> listaUsuario = new List<Usuario>();
    }
}
