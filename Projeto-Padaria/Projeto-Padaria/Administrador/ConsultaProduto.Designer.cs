namespace Projeto_Padaria.Administrador
{
    partial class ConsultaProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCodBarras = new MetroFramework.Controls.MetroRadioButton();
            this.rdNome = new MetroFramework.Controls.MetroRadioButton();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoBarras = new MetroFramework.Controls.MetroTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.txtValidade = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEstoque = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMarca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnApagar = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCodBarras);
            this.groupBox1.Controls.Add(this.rdNome);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por:";
            // 
            // rdCodBarras
            // 
            this.rdCodBarras.AutoSize = true;
            this.rdCodBarras.Location = new System.Drawing.Point(6, 51);
            this.rdCodBarras.Name = "rdCodBarras";
            this.rdCodBarras.Size = new System.Drawing.Size(113, 15);
            this.rdCodBarras.TabIndex = 1;
            this.rdCodBarras.Text = "Código de barras";
            this.rdCodBarras.UseVisualStyleBackColor = true;
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
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(173, 85);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(393, 23);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(173, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Valor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(173, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(572, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(572, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 23);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(23, 143);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(543, 184);
            this.dataGridProdutos.TabIndex = 6;
            this.dataGridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellClick);
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(572, 143);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(202, 184);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagem.TabIndex = 7;
            this.pictureBoxImagem.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(572, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Imagem";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Código de barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Enabled = false;
            this.txtCodigoBarras.Location = new System.Drawing.Point(3, 41);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(196, 23);
            this.txtCodigoBarras.TabIndex = 10;
            this.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.txtValidade);
            this.panel.Controls.Add(this.metroLabel12);
            this.panel.Controls.Add(this.txtQuantidade);
            this.panel.Controls.Add(this.metroLabel11);
            this.panel.Controls.Add(this.txtEstoque);
            this.panel.Controls.Add(this.metroLabel10);
            this.panel.Controls.Add(this.txtPreco);
            this.panel.Controls.Add(this.metroLabel9);
            this.panel.Controls.Add(this.txtMarca);
            this.panel.Controls.Add(this.metroLabel8);
            this.panel.Controls.Add(this.txtNomeP);
            this.panel.Controls.Add(this.metroLabel7);
            this.panel.Controls.Add(this.metroLabel6);
            this.panel.Controls.Add(this.txtObs);
            this.panel.Controls.Add(this.metroLabel5);
            this.panel.Controls.Add(this.txtDescricao);
            this.panel.Location = new System.Drawing.Point(24, 334);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(542, 179);
            this.panel.TabIndex = 11;
            // 
            // txtValidade
            // 
            this.txtValidade.Enabled = false;
            this.txtValidade.Location = new System.Drawing.Point(458, 40);
            this.txtValidade.Mask = "00/00/0000";
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(81, 20);
            this.txtValidade.TabIndex = 28;
            this.txtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(394, 41);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(58, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Validade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(349, 41);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(39, 23);
            this.txtQuantidade.TabIndex = 26;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(265, 41);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(78, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Quantidade";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(220, 41);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(39, 23);
            this.txtEstoque.TabIndex = 24;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(124, 41);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(84, 19);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "Estoque Mín.";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(55, 41);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(63, 23);
            this.txtPreco.TabIndex = 22;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(5, 41);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(43, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Preço";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(317, 12);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(222, 23);
            this.txtMarca.TabIndex = 20;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(265, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Marca";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Enabled = false;
            this.txtNomeP.Location = new System.Drawing.Point(55, 12);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(204, 23);
            this.txtNomeP.TabIndex = 18;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 12);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Nome";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(265, 66);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Obs";
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(265, 88);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(274, 88);
            this.txtObs.TabIndex = 15;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(5, 66);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(3, 88);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(256, 88);
            this.txtDescricao.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.metroLabel15);
            this.panel2.Controls.Add(this.metroLabel14);
            this.panel2.Controls.Add(this.metroLabel13);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.txtCodigoBarras);
            this.panel2.Location = new System.Drawing.Point(572, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 179);
            this.panel2.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 519);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 37);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(124, 519);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 37);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(683, 519);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 37);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(225, 519);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(326, 519);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(95, 37);
            this.btnApagar.TabIndex = 17;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 20);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 20);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(3, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 20);
            this.panel4.TabIndex = 13;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(32, 98);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(109, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "Estoque negativo";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(32, 123);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(91, 19);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "Estoque baixo";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(32, 150);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(104, 19);
            this.metroLabel15.TabIndex = 20;
            this.metroLabel15.Text = "Estoque positivo";
            // 
            // ConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 579);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaProduto";
            this.Text = "Consulta de Produto";
            this.Load += new System.EventHandler(this.ConsultaProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdCodBarras;
        private MetroFramework.Controls.MetroRadioButton rdNome;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCodigoBarras;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private MetroFramework.Controls.MetroTextBox txtNomeP;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtMarca;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtQuantidade;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.MaskedTextBox txtValidade;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnApagar;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}