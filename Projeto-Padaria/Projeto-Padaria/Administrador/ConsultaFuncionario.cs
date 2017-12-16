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
    public partial class ConsultaFuncionario : MetroFramework.Forms.MetroForm
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();
        }

        Classes.Conexao con = new Classes.Conexao();

        private void NomearDataGrid()
        {
            gridFuncionarios.ColumnCount = 15;
            gridFuncionarios.Columns[0].Name = "ID";
            gridFuncionarios.Columns[1].Name = "Nome";
            gridFuncionarios.Columns[2].Name = "Sexo";
            gridFuncionarios.Columns[3].Name = "Cargo";
            gridFuncionarios.Columns[4].Name = "Data de Nascimento";
            gridFuncionarios.Columns[5].Name = "Contratação";
            gridFuncionarios.Columns[6].Name = "CEP";
            gridFuncionarios.Columns[7].Name = "Numero";
            gridFuncionarios.Columns[8].Name = "Email";
            gridFuncionarios.Columns[9].Name = "Telefone";
            gridFuncionarios.Columns[10].Name = "Endereco";
            gridFuncionarios.Columns[10].Visible = false;
            gridFuncionarios.Columns[11].Name = "Bairro";
            gridFuncionarios.Columns[11].Visible = false;
            gridFuncionarios.Columns[12].Name = "Cidade";
            gridFuncionarios.Columns[12].Visible = false;
            gridFuncionarios.Columns[13].Name = "Estado";
            gridFuncionarios.Columns[13].Visible = false;
            gridFuncionarios.Columns[14].Name = "Obs";
            gridFuncionarios.Columns[14].Visible = false;
        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            NomearDataGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.FormClosed += (s, args) => Close();
            telaPrincipal.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            gridFuncionarios.Rows.Clear();

            string pesquisa = txtPesquisa.Text;
            string query;

            SqlConnection conexao = con.Conectar();

            if (rdNome.Checked)
            {
                try
                {
                    query = "SELECT * FROM funcionario WHERE nome LIKE '%" + pesquisa + "%'";

                    SqlCommand comando = new SqlCommand(query, conexao);

                    SqlDataReader dr = comando.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Não foram encontrados funcionários",
                            "Consulta por nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else
                    {
                        while (dr.Read())
                        {
                            gridFuncionarios.Rows.Add(dr["id"].ToString(), dr["nome"].ToString(), dr["sexo"].ToString(), dr["cargo"].ToString(), dr["nascimento"].ToString(), dr["contratacao"].ToString(), dr["CEP"].ToString(), dr["numero"].ToString(), dr["email"].ToString(), dr["telefone"].ToString(), dr["endereco"].ToString(), dr["bairro"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["obs"].ToString());
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao listar funcionários: " + ex,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else if (rdId.Checked)
            {
                try
                {
                    query = "SELECT * FROM funcionario WHERE id = @ID;";

                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ID", txtPesquisa.Text);

                    SqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Não foram encontrados funcionários",
                            "Consulta por nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        gridFuncionarios.Rows.Add(dr["id"].ToString(), dr["nome"].ToString(), dr["sexo"].ToString(), dr["cargo"].ToString(), dr["nascimento"].ToString(), dr["contratacao"].ToString(), dr["CEP"].ToString(), dr["numero"].ToString(), dr["email"].ToString(), dr["telefone"].ToString(), dr["endereco"].ToString(), dr["bairro"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["obs"].ToString());


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar funcionário: " + ex,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridFuncionarios.Rows.Clear();

            try
            {
                SqlConnection conexao = con.Conectar();

                string query = "SELECT * FROM funcionario";

                SqlCommand comando = new SqlCommand(query, conexao);

                SqlDataReader dr = comando.ExecuteReader();

                    while(dr.Read())
                        gridFuncionarios.Rows.Add(dr["id"].ToString(), dr["nome"].ToString(), dr["sexo"].ToString(), dr["cargo"].ToString(), dr["nascimento"].ToString(), dr["contratacao"].ToString(), dr["CEP"].ToString(), dr["numero"].ToString(), dr["email"].ToString(), dr["telefone"].ToString(), dr["endereco"].ToString(), dr["bairro"].ToString(), dr["cidade"].ToString(), dr["estado"].ToString(), dr["obs"].ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNome.Enabled = true;
            txtNascimento.Enabled = true;
            txtContratacao.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbEstado.Enabled = true;
            txtCEP.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtObs.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtNascimento.Clear();
            txtContratacao.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.Text = "";
            txtCEP.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtObs.Clear();
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNome.Enabled = false;
            txtNascimento.Enabled = false;
            txtContratacao.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbEstado.Enabled = false;
            txtCEP.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtObs.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
        }

        private void gridFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblid.Text = gridFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = gridFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNascimento.Text = gridFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtContratacao.Text = gridFuncionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEndereco.Text = gridFuncionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtNumero.Text = gridFuncionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtBairro.Text = gridFuncionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtCidade.Text = gridFuncionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                cbEstado.Text = gridFuncionarios.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtCEP.Text = gridFuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTelefone.Text = gridFuncionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtEmail.Text = gridFuncionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtObs.Text = gridFuncionarios.Rows[e.RowIndex].Cells[14].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = con.Conectar();

                string query = "UPDATE funcionario SET nome = @Nome, nascimento = @DataNascimento, contratacao = @Contratacao, endereco = @Endereco, numero = @Numero, bairro = @Bairro, cidade = @Cidade, estado = @Estado, CEP = @CEP, telefone = @Telefone, email = @Email, obs = @Obs WHERE id = @ID";

                SqlCommand comando = new SqlCommand(query, conexao);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@DataNascimento", txtNascimento.Text);
                comando.Parameters.AddWithValue("@Contratacao", txtContratacao.Text);
                comando.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@Numero", txtNumero.Text);
                comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@Estado", cbEstado.Text);
                comando.Parameters.AddWithValue("@CEP", txtCEP.Text);
                comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                comando.Parameters.AddWithValue("@Obs", txtObs.Text);
                comando.Parameters.AddWithValue("@ID", lblid.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Funcionário editado com sucesso.",
                    "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DesabilitarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar: " + ex);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você tem certeza?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    SqlConnection conexao = con.Conectar();

                    string query = "DELETE FROM funcionario WHERE id = @ID;";

                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ID", lblid.Text);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Apagado com sucesso!", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar: " + ex, "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
