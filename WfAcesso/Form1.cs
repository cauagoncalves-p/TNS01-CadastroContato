using System.Drawing.Text;

namespace WfAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarLogin();
        }
        public void CarregarLogin()
        {
            Usuario.listaUsuario.Add(new Usuario { 
                Codigo = 1,
                Login = "Admin", 
                Senha = "Admin", 
                DataCadastro =  Convert.ToDateTime("01/01/2000")
            });

            Usuario.listaUsuario.Add(new Usuario
            {
                Codigo = 2,
                Login = "User", 
                Senha = "User", 
                DataCadastro = Convert.ToDateTime("01/10/2010")
            });
        }

        private void Error(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Logado(string messgae) {
            MessageBox.Show(messgae, "Logado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (string.IsNullOrEmpty(txtUsuario.Text)) 
            {
                Error("Usuario não pode ser nulo");
                return;
            }
            if(string.IsNullOrEmpty(txtSenha.Text))
            {
                Error("Senha não pode ser nulo");
                return;
            }

            usuario.Login = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            foreach (var item in Usuario.listaUsuario)
            {
                if (usuario.Login == item.Login && usuario.Senha == item.Senha )
                {
                    Logado("Olá. você conseguiu logar no programa!");
                    return;
                }
            }
            Error("Usuario ou senha errado!");
        }
    }
}
