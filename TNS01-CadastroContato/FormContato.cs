using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNS01_CadastroContato
{
    public partial class FormContato : Form
    {
        public FormContato()
        {
            InitializeComponent();
        }

        private void LimparCadastro() {
            txtEmail.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
            mkdTelefone.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = txtNome.Text;
            contato.Sobrenome = txtSobrenome.Text;
            contato.Telefone = mkdTelefone.Text;
            // 11 98887-4587
            // 01 2345678910

            if (rdbPessoal.Checked)
            {
                contato.TelefoneChar = Contato.TipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                contato.TelefoneChar = Contato.TipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                contato.TelefoneChar = Contato.TipoTelefone.Recado ;
            }
            else 
            {
                MessageBox.Show("Selecione alguma opção de telefone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contato.Email = txtEmail.Text;

            Contato.CadastroContato.Add(contato);

            MessageBox.Show("Cadastrado com sucesso!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCadastro();

            MessageBox.Show($"Nome: {contato.Nome}\n Sobrenome: {contato.Sobrenome}\n Telefone: {contato.Telefone}\n Opção de contato escolhida: {contato.TelefoneChar}\n Email: {contato.Email}");
        }
    }
}
