using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Padaria
{
    public partial class TelaPrincipal : MetroFramework.Forms.MetroForm
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja realmente sair?",
                "Sair",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2))
            {
                Close();
            }

            
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador.LoginAdministrador form1 = new Administrador.LoginAdministrador();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador.CadastroFuncionario CadastroFuncionario = new Administrador.CadastroFuncionario();
            CadastroFuncionario.FormClosed += (s, args) => this.Close();
            CadastroFuncionario.Show();
        }

        private void funcionárosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.ConsultaFuncionario consultaFuncionario = new Administrador.ConsultaFuncionario();
            consultaFuncionario.FormClosed += (s, args) => Close();
            consultaFuncionario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.CadastroProduto cadProduto = new Administrador.CadastroProduto();
            cadProduto.FormClosed += (s, args) => Close();
            cadProduto.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.Sobre sobre = new Administrador.Sobre();
            sobre.FormClosed += (s, args) => Close();
            sobre.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador.CadastroFuncionario CadastroFuncionario = new Administrador.CadastroFuncionario();
            CadastroFuncionario.FormClosed += (s, args) => this.Close();
            CadastroFuncionario.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.CadastroProduto cadProduto = new Administrador.CadastroProduto();
            cadProduto.FormClosed += (s, args) => Close();
            cadProduto.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.ConsultaProduto conProd = new Administrador.ConsultaProduto();
            conProd.FormClosed += (s, args) => this.Close();
            conProd.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.ConsultaProduto conProd = new Administrador.ConsultaProduto();
            conProd.FormClosed += (s, args) => this.Close();
            conProd.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Hide();
            Administrador.ConsultaFuncionario consultaFuncionario = new Administrador.ConsultaFuncionario();
            consultaFuncionario.FormClosed += (s, args) => Close();
            consultaFuncionario.Show();
        }
    }
}
