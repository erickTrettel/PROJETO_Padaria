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
    public partial class CadastroFuncionario : MetroFramework.Forms.MetroForm
    {
        public CadastroFuncionario()
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

        private void txtNome_Leave(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                string numUser = rand.Next(1000, 9999).ToString();

                string nome = txtNome.Text;
                string letraNome = nome[0].ToString().ToUpper();
                string nomeUsuario = letraNome + "-" + numUser;

                txtUsuario.Text = nomeUsuario;
            }
            catch
            {
                MessageBox.Show("Preencha o campo nome", 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                txtNome.Focus();
            }
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtNascimento.Clear();
            txtContratacao.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtObs.Clear();
            txtCEP.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Funcionario func = new Classes.Funcionario();

            func.NivelAcesso = txtCargo.Text.ToLower();
            func.Usuario = txtUsuario.Text;
            func.Nome = txtNome.Text;
            func.Sexo = (rdMasculino.Checked) ? "M" : "F";
            func.Cargo = txtCargo.Text;
            func.DataNascimento = txtNascimento.Text;
            func.Contratacao = txtContratacao.Text;
            func.Endereco = txtEndereco.Text;
            func.Numero = txtNumero.Text;
            func.Bairro = txtBairro.Text;
            func.Cidade = txtCidade.Text;
            func.Estado = txtEstado.Text;
            func.CEP = txtCEP.Text;
            func.Pais = txtPais.Text;
            func.Telefone = txtTelefone.Text;
            func.Email = txtEmail.Text;
            func.Senha = txtSenha.Text;
            func.Obs = txtObs.Text;

            string mensagem = func.Cadastrar();
            
            if(mensagem == "Cadastro realizado com sucesso!")
            {
                MessageBox.Show(mensagem, 
                    "Cadastro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                Limpar();
            }else
            {
                MessageBox.Show(mensagem,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
