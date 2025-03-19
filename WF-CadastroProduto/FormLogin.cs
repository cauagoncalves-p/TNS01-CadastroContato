using System.Drawing.Text;

namespace WF_CadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLogin();
        }
        public void CarregarLogin()
        {
            Usuario.listaUsuario.Add(new Usuario
            {
                Codigo = 001,
                Login = "admin", 
                Senha = "123456", 
                ConfirmarSenha = "123456",
                DataCadastro = Convert.ToDateTime("18/03/2025")
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
                    FormMain form = new FormMain();
                    form.ShowDialog();

                    txtUsuario.Clear();
                    txtSenha.Clear();
                    
                    return;
                }
            }
            Error("Usuario ou senha errado!");
        }
    }
}
