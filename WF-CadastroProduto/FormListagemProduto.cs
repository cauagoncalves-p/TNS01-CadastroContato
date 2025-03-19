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
    public partial class FormListagemProduto : Form
    {
        public FormListagemProduto()
        {
            InitializeComponent();
        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            dgvListaContatos.DataSource = Produto.ListaProduto;
        }
    }
}
