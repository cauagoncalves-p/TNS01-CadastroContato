namespace TN01_WFUsandoListagem
{
    partial class FormCadastro
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
            btnCadastrar = new Button();
            lblLogin = new Label();
            lblconfirmarSenha = new Label();
            lblSenha = new Label();
            txtLogin = new TextBox();
            txtconfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(25, 214);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(208, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(25, 38);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblconfirmarSenha
            // 
            lblconfirmarSenha.AutoSize = true;
            lblconfirmarSenha.Location = new Point(24, 161);
            lblconfirmarSenha.Name = "lblconfirmarSenha";
            lblconfirmarSenha.Size = new Size(96, 15);
            lblconfirmarSenha.TabIndex = 2;
            lblconfirmarSenha.Text = "Confirmar Senha";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(25, 109);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(137, 38);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 4;
            // 
            // txtconfirmarSenha
            // 
            txtconfirmarSenha.Location = new Point(137, 158);
            txtconfirmarSenha.Name = "txtconfirmarSenha";
            txtconfirmarSenha.PlaceholderText = "*";
            txtconfirmarSenha.Size = new Size(100, 23);
            txtconfirmarSenha.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(137, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "*";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 6;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 278);
            Controls.Add(txtSenha);
            Controls.Add(txtconfirmarSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblconfirmarSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblLogin;
        private Label lblconfirmarSenha;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtconfirmarSenha;
        private TextBox txtSenha;
    }
}