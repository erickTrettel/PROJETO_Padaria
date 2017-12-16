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

namespace Projeto_Padaria.Administrador
{
    public partial class LoginAdministrador : MetroFramework.Forms.MetroForm
    {
        public LoginAdministrador()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string caminhoConexao = Properties.Settings.Default.BD_Padaria;
            SqlConnection Conexao = new SqlConnection(caminhoConexao);
            Conexao.Open();

            string usuario = txtUsuario.Text, senha = txtSenha.Text;

            string nivelAcesso = "";

            string query = "SELECT * FROM funcionario WHERE usuario = '"+usuario+"' AND senha = '"+senha+"' ";

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader dados = Comando.ExecuteReader();

            if (dados.Read())
            {
                nivelAcesso = dados["nivelacesso"].ToString();

                if(nivelAcesso == "master")
                {
                    this.Hide();
                    TelaPrincipal TelaPrincipal = new TelaPrincipal();
                    TelaPrincipal.Closed += (s, args) => this.Close();
                    TelaPrincipal.Show();
                }else if(nivelAcesso == "operador")
                {
                    this.Hide();
                    Funcionario.TelaFuncionario TelaFuncionario = new Funcionario.TelaFuncionario();
                    TelaFuncionario.FormClosed += (s, args) => this.Close();
                    TelaFuncionario.Show();
                }else
                {
                    MessageBox.Show("Temos problemas");
                }
            }
            else
            {
                MessageBox.Show("Erro ao realizar login, verifique se seus dados estão corretos!", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
