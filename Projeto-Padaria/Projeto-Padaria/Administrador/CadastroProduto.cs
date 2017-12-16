using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Padaria.Administrador
{
    public partial class CadastroProduto : MetroFramework.Forms.MetroForm
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal Tela = new TelaPrincipal();
            Tela.Closed += (s, args) => this.Close();
            Tela.Show();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagem = openFileDialog1.FileName;

                Bitmap bmp = new Bitmap(imagem);
                pictureBoxImagem.Image = bmp;
                txtImagem.Text = Application.StartupPath.ToString() + "\\Produto\\Imagens\\" + txtNome.Text + ".jpeg";                
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Produto prod = new Classes.Produto();

            prod.CodigoBarras = txtCodBarras.Text;
            prod.Nome = txtNome.Text;
            prod.Marca = txtMarca.Text;
            prod.Descricao = txtDescricao.Text;
            prod.PrecoVenda = float.Parse(txtPreco.Text);
            prod.Imagem = Application.StartupPath.ToString() + "\\Produto\\Imagens\\" + txtNome.Text + ".jpeg";
            prod.EstoqueMinimo = int.Parse(txtEstoque.Text);
            prod.Quantidade = int.Parse(txtQuantidade.Text);
            prod.DataValidade = txtDataValidade.Text;
            prod.Obs = txtObs.Text;

            string mensagem = prod.Cadastrar();

            if (mensagem == "Produto cadastrado com sucesso!")
            {
                pictureBoxImagem.Image.Save(Application.StartupPath.ToString() + "\\Produto\\Imagens\\" + txtNome.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpar();
        }

        private void Limpar()
        {
            txtCodBarras.Text = "";
            txtDataValidade.Text = "";
            txtDescricao.Text = "";
            txtEstoque.Text = "";
            txtImagem.Text = "";
            txtMarca.Text = "";
            txtNome.Text = "";
            txtObs.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }
    }
}
