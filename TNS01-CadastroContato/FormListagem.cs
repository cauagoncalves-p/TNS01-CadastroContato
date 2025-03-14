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
    public partial class FormListagem : Form
    {
        public FormListagem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaContatos.DataSource = Contato.CadastroContato;
        }
    }
}
