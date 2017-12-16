namespace Projeto_Padaria.Administrador
{
    partial class LoginAdministrador
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
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblSair = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsuario.Location = new System.Drawing.Point(23, 99);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 30);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.Location = new System.Drawing.Point(23, 143);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(217, 30);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 35);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSair
            // 
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lblSair.Location = new System.Drawing.Point(167, 327);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(75, 23);
            this.lblSair.TabIndex = 11;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // LoginAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 373);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 373);
            this.MinimumSize = new System.Drawing.Size(265, 373);
            this.Name = "LoginAdministrador";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Text = "Login";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLink lblSair;
    }
}