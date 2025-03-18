using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void LimparTela() 
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtconfirmarSenha.Clear();
        }

        private void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Logado(string messgae)
        {
            MessageBox.Show(messgae, "Logado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (string.IsNullOrEmpty(txtLogin.Text)) 
            {
                Error("Login não pode ser nulo");
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Error("Senha não pode ser nulo");
                return;
            }

            if (string.IsNullOrEmpty(txtconfirmarSenha.Text))
            {
                Error("Confirmar senha não pode ser nulo");
                return;
            }

            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.ConfirmarSenha = txtconfirmarSenha.Text;

            if (usuario.Senha != usuario.ConfirmarSenha)
            {
                Error("Senhas não podem ser diferentes");
                return;
            }

            else 
            {
                Logado("Cadastro realizado");
                LimparTela();
            }
            
            Usuario.listaUsuario.Add(usuario);


        }
    }
}
