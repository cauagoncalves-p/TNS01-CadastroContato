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

            if (rdbPessoal.Checked)
            {
                contato.TelefoneChar = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                contato.TelefoneChar = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                contato.TelefoneChar = "Recado";
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
        }
    }
}
