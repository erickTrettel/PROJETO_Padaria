namespace Projeto_Padaria.Administrador
{
    partial class ConsultaFuncionario
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
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.gridFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdId = new MetroFramework.Controls.MetroRadioButton();
            this.rdNome = new MetroFramework.Controls.MetroRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtContratacao = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lblid = new MetroFramework.Controls.MetroLabel();
            this.btnApagar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(173, 86);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(443, 23);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(622, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionarios.Location = new System.Drawing.Point(23, 143);
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.Size = new System.Drawing.Size(668, 210);
            this.gridFuncionarios.TabIndex = 3;
            this.gridFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncionarios_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(600, 543);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 46);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 543);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 46);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(362, 543);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 46);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Todos os funcionários";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdId);
            this.groupBox1.Controls.Add(this.rdNome);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por:";
            // 
            // rdId
            // 
            this.rdId.AutoSize = true;
            this.rdId.Location = new System.Drawing.Point(6, 51);
            this.rdId.Name = "rdId";
            this.rdId.Size = new System.Drawing.Size(34, 15);
            this.rdId.TabIndex = 1;
            this.rdId.TabStop = true;
            this.rdId.Text = "ID";
            this.rdId.UseVisualStyleBackColor = true;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Checked = true;
            this.rdNome.Location = new System.Drawing.Point(6, 30);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(56, 15);
            this.rdNome.TabIndex = 0;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtContratacao);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtNascimento);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(23, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 178);
            this.panel1.TabIndex = 8;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(486, 31);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(168, 120);
            this.txtObs.TabIndex = 23;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(486, 9);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(33, 19);
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "Obs";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(310, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 23);
            this.txtEmail.TabIndex = 21;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(256, 128);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(310, 99);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(153, 23);
            this.txtTelefone.TabIndex = 19;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(256, 99);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(27, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Tel.";
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Location = new System.Drawing.Point(310, 73);
            this.txtCEP.Mask = "00,000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(94, 20);
            this.txtCEP.TabIndex = 17;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(256, 74);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "CEP";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(256, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.ItemHeight = 23;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(310, 38);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(153, 29);
            this.cbEstado.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(310, 9);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(153, 23);
            this.txtCidade.TabIndex = 13;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(256, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Cidade";
            // 
            // txtContratacao
            // 
            this.txtContratacao.Enabled = false;
            this.txtContratacao.Location = new System.Drawing.Point(140, 64);
            this.txtContratacao.Mask = "00/00/0000";
            this.txtContratacao.Name = "txtContratacao";
            this.txtContratacao.Size = new System.Drawing.Size(108, 20);
            this.txtContratacao.TabIndex = 11;
            this.txtContratacao.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(112, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Data Contratação";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Enabled = false;
            this.txtNascimento.Location = new System.Drawing.Point(140, 38);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(108, 20);
            this.txtNascimento.TabIndex = 9;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Data de Nascimento";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(76, 150);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(172, 23);
            this.txtBairro.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(76, 121);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(172, 23);
            this.txtNumero.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Numero";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(76, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(172, 23);
            this.txtEndereco.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(58, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 23);
            this.txtNome.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(189, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(106, 543);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 46);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(174, 109);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(0, 0);
            this.metroLabel13.TabIndex = 11;
            this.metroLabel13.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(183, 114);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 0);
            this.lblid.TabIndex = 12;
            this.lblid.Visible = false;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(277, 543);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(79, 46);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // ConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 603);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "ConsultaFuncionario";
            this.Text = "Consulta de Funcionário";
            this.Load += new System.EventHandler(this.ConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private System.Windows.Forms.DataGridView gridFuncionarios;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdId;
        private MetroFramework.Controls.MetroRadioButton rdNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtContratacao;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbEstado;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lblid;
        private MetroFramework.Controls.MetroButton btnApagar;
    }
}