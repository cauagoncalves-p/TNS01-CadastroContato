namespace TNS01_CadastroContato
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            lblNome = new Label();
            txtNome = new TextBox();
            lblSobrenome = new Label();
            txtSobrenome = new TextBox();
            label1 = new Label();
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            gpxTipoTelefone = new GroupBox();
            rdbComercial = new RadioButton();
            rdbRecado = new RadioButton();
            rdbPessoal = new RadioButton();
            label2 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gpxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(23, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 1;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(314, 18);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 2;
            lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(314, 46);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(191, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(23, 104);
            label1.Name = "label1";
            label1.Size = new Size(500, 1);
            label1.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(23, 138);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(80, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "DDD/Telefone";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(23, 180);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 6;
            // 
            // gpxTipoTelefone
            // 
            gpxTipoTelefone.Controls.Add(rdbComercial);
            gpxTipoTelefone.Controls.Add(rdbRecado);
            gpxTipoTelefone.Controls.Add(rdbPessoal);
            gpxTipoTelefone.Location = new Point(227, 138);
            gpxTipoTelefone.Name = "gpxTipoTelefone";
            gpxTipoTelefone.Size = new Size(294, 65);
            gpxTipoTelefone.TabIndex = 8;
            gpxTipoTelefone.TabStop = false;
            gpxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(92, 22);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 2;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(199, 22);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 1;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(9, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(16, 225);
            label2.Name = "label2";
            label2.Size = new Size(500, 1);
            label2.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 274);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 242);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(252, 375);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(114, 45);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(382, 375);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(123, 45);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(gpxTipoTelefone);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(label1);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de contato ";
            gpxTipoTelefone.ResumeLayout(false);
            gpxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label label1;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private GroupBox gpxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoal;
        private Label label2;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}