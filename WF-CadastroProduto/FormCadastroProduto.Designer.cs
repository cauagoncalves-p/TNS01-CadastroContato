namespace WF_CadastroProduto
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            lblPreco = new Label();
            nudPreco = new NumericUpDown();
            dtpDataVencimento = new DateTimePicker();
            lblDataVencimento = new Label();
            txtDescricao = new TextBox();
            lblObservacao = new Label();
            btnSalvar = new Button();
            mktCodigo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 42);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(163, 42);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.IntegralHeight = false;
            cbxCategoria.Items.AddRange(new object[] { "Eletrônicos", "Roupas", "Alimentos", "Bebidas", "Móveis", "Cosméticos", "Brinquedos", "Automotivos", "Esportes", "Ferramentas", "Livros", "Papelaria", "PetShop", "Saúde", "Casa e Jardim" });
            cbxCategoria.Location = new Point(148, 76);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(12, 122);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 151);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(248, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 194);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.ImeMode = ImeMode.NoControl;
            nudPreco.Location = new Point(12, 233);
            nudPreco.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(100, 23);
            nudPreco.TabIndex = 5;
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Format = DateTimePickerFormat.Short;
            dtpDataVencimento.Location = new Point(148, 233);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(105, 23);
            dtpDataVencimento.TabIndex = 4;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(148, 194);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(100, 15);
            lblDataVencimento.TabIndex = 10;
            lblDataVencimento.Text = "Data Vencimento ";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 314);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(248, 129);
            txtDescricao.TabIndex = 6;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(12, 282);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 12;
            lblObservacao.Text = "Observação";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 465);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 38);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mktCodigo
            // 
            mktCodigo.Location = new Point(10, 76);
            mktCodigo.Mask = "000000";
            mktCodigo.Name = "mktCodigo";
            mktCodigo.Size = new Size(100, 23);
            mktCodigo.TabIndex = 15;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 575);
            Controls.Add(mktCodigo);
            Controls.Add(btnSalvar);
            Controls.Add(lblObservacao);
            Controls.Add(txtDescricao);
            Controls.Add(lblDataVencimento);
            Controls.Add(dtpDataVencimento);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCategoria;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private Label lblPreco;
        private NumericUpDown nudPreco;
        private DateTimePicker dtpDataVencimento;
        private Label lblDataVencimento;
        private TextBox txtDescricao;
        private Label lblObservacao;
        private Button btnSalvar;
        public ComboBox cbxCategoria;
        private MaskedTextBox mktCodigo;
    }
}