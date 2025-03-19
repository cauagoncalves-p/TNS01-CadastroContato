using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
            dtpDataVencimento.Value = DateTime.Today;
        }

        private void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Logado(string messgae)
        {
            MessageBox.Show(messgae, "Logado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparTela() 
        {
            txtNomeProduto.Clear();
            txtDescricao.Clear();
            mktCodigo.Clear();
            nudPreco.Value = 0;
            cbxCategoria.SelectedIndex = -1;
            dtpDataVencimento.Value = DateTime.Today;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             Produto produto = new Produto();

            if (mktCodigo.Text == "" )
            {
                Error("Código do produto não pode ser nulo");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Error("Nome do produto não pode ser nulo");
                return;
            }

            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Error("Categoria não pode ser nulo");
                return;
            }

            if (dtpDataVencimento.Value == DateTime.Today)
            {
                Error("Data de validade não pode ser nulo");
                return;
            }

            if (nudPreco.Value <= 0 )
            {
                Error("Preço não pode ser menor que 0 ");
                return;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Error("Observaçao não pode ser nulo");
                return;
            }

            produto.Codigo = int.Parse(mktCodigo.Text);
            produto.Nome = txtNomeProduto.Text;
            produto.Categoria = cbxCategoria.Text;      
            produto.DataVencimento = dtpDataVencimento.Value;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = double.Parse(nudPreco.Value.ToString());

            foreach (var item in Produto.ListaProduto) 
            {
                if (produto.Codigo == item.Codigo)
                {
                    Error("Código do produto já cadastrado");
                    return;
                }
            }

            Logado("Produto cadastrado com sucesso!");
            LimparTela();
            Produto.ListaProduto.Add(produto);
        }
    }
}
