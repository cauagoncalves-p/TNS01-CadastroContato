namespace WF_CadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(24, 43);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(24, 125);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 21);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(24, 80);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Wingdings", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtSenha.Location = new Point(24, 166);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = 'l';
            txtSenha.Size = new Size(100, 21);
            txtSenha.TabIndex = 3;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Green;
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(24, 217);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 25);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 287);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Acesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogar;
    }
}
