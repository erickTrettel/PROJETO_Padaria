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
    public partial class ConsultaProduto : MetroFramework.Forms.MetroForm
    {
        public ConsultaProduto()
        {
            InitializeComponent();
        }

        Classes.Conexao con = new Classes.Conexao();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.FormClosed += (s, args) => Close();
            telaPrincipal.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNomeP.Enabled = true;
            txtPreco.Enabled = true;
            txtEstoque.Enabled = true;
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValidade.Enabled = true;
            txtObs.Enabled = true;
        }

        private void NomearDataGrid()
        {
            dataGridProdutos.ColumnCount = 10;
            dataGridProdutos.Columns[0].Name = "Código de barras";
            dataGridProdutos.Columns[1].Name = "Produto";
            dataGridProdutos.Columns[1].Width = 250;
            dataGridProdutos.Columns[2].Name = "Marca";
            dataGridProdutos.Columns[3].Name = "Preço";
            dataGridProdutos.Columns[4].Name = "Quantidade";
            dataGridProdutos.Columns[5].Name = "Data de validade";
            dataGridProdutos.Columns[6].Name = "Estoque";
            dataGridProdutos.Columns[6].Visible = false;
            dataGridProdutos.Columns[7].Name = "Imagem";
            dataGridProdutos.Columns[7].Visible = false;
            dataGridProdutos.Columns[8].Name = "Obs";
            dataGridProdutos.Columns[8].Visible = false;
            dataGridProdutos.Columns[9].Name = "Descricao";
            dataGridProdutos.Columns[9].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dataGridProdutos.Rows.Clear();

            if (rdNome.Checked)
            {
                try
                {
                    SqlConnection conexao = con.Conectar();

                    string queryNome = "SELECT * FROM produto WHERE pr_nome LIKE '%"+txtPesquisa.Text+"%';";

                    SqlCommand comando = new SqlCommand(queryNome, conexao);

                    SqlDataReader dr = comando.ExecuteReader();

                    if (!dr.HasRows)
                        MessageBox.Show("Produto não encontrado", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {                      
                        while(dr.Read())
                            dataGridProdutos.Rows.Add(dr["pr_codigobarras"].ToString(), dr["pr_nome"].ToString(), dr["pr_marca"].ToString(), dr["pr_precovenda"].ToString(), dr["pr_quantidade"].ToString(), dr["pr_datavalidade"].ToString(), dr["pr_estoqueminimo"].ToString(), dr["pr_imagem"].ToString(), dr["pr_obs"].ToString(), dr["pr_descricao"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }else if (rdCodBarras.Checked)
            {

                try
                {
                    SqlConnection conexao = con.Conectar();

                    string queryCodBarras = "SELECT * FROM produto WHERE pr_codigobarras = @CodBarras";

                    SqlCommand comando = new SqlCommand(queryCodBarras, conexao);

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodBarras", txtPesquisa.Text);

                    SqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    if (!dr.HasRows)
                        MessageBox.Show("Produto não encontrado", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        dataGridProdutos.Rows.Add(dr["pr_codigobarras"].ToString(), dr["pr_nome"].ToString(), dr["pr_marca"].ToString(), dr["pr_precovenda"].ToString(), dr["pr_quantidade"].ToString(), dr["pr_datavalidade"].ToString(), dr["pr_estoqueminimo"].ToString(), dr["pr_imagem"].ToString(), dr["pr_obs"].ToString(), dr["pr_descricao"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

            }

        }

        private void ConsultaProduto_Load(object sender, EventArgs e)
        {
            NomearDataGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNomeP.Enabled = false;
            txtPreco.Enabled = false;
            txtEstoque.Enabled = false;
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValidade.Enabled = false;
            txtObs.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNomeP.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtQuantidade.Clear();
            txtValidade.Clear();
            txtObs.Clear();
        }

        private void dataGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNome.Text = dataGridProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
                pictureBoxImagem.ImageLocation = dataGridProdutos.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtCodigoBarras.Text = dataGridProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomeP.Text = dataGridProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPreco.Text = dataGridProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEstoque.Text = dataGridProdutos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMarca.Text = dataGridProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantidade.Text = dataGridProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtValidade.Text = dataGridProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtObs.Text = dataGridProdutos.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDescricao.Text = dataGridProdutos.Rows[e.RowIndex].Cells[9].Value.ToString();

                int quantidade = int.Parse(txtQuantidade.Text);
                int estoqueMinimo = int.Parse(txtEstoque.Text);

                if (quantidade - estoqueMinimo <= 0)
                    panel.BackColor = Color.Red;
                else if (quantidade - estoqueMinimo < 10)
                    panel.BackColor = Color.Orange;
                else
                    panel.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Classes.Produto prod = new Classes.Produto();

            prod.Nome = txtNomeP.Text;
            prod.PrecoVenda = float.Parse(txtPreco.Text);
            prod.EstoqueMinimo = int.Parse(txtEstoque.Text);
            prod.Descricao = txtDescricao.Text;
            prod.Marca = txtMarca.Text;
            prod.Quantidade = int.Parse(txtQuantidade.Text);
            prod.DataValidade = txtValidade.Text;
            prod.Obs = txtObs.Text;
            prod.CodigoBarras = txtCodigoBarras.Text;

            string mensagem = prod.Editar();

            if (mensagem == "Produto editado com sucesso")
                MessageBox.Show(mensagem, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensagem, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DesabilitarCampos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridProdutos.Rows.Clear();

            if (rdNome.Checked)
            {
                try
                {
                    SqlConnection conexao = con.Conectar();

                    string queryNome = "SELECT * FROM produto WHERE pr_nome LIKE '%" + txtPesquisa.Text + "%';";

                    SqlCommand comando = new SqlCommand(queryNome, conexao);

                    SqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                            dataGridProdutos.Rows.Add(dr["pr_codigobarras"].ToString(), dr["pr_nome"].ToString(), dr["pr_marca"].ToString(), dr["pr_precovenda"].ToString(), dr["pr_quantidade"].ToString(), dr["pr_datavalidade"].ToString(), dr["pr_estoqueminimo"].ToString(), dr["pr_imagem"].ToString(), dr["pr_obs"].ToString(), dr["pr_descricao"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
            else if (rdCodBarras.Checked)
            {

                try
                {
                    SqlConnection conexao = con.Conectar();

                    string queryCodBarras = "SELECT * FROM produto WHERE pr_codigobarras = @CodBarras";

                    SqlCommand comando = new SqlCommand(queryCodBarras, conexao);

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodBarras", txtPesquisa.Text);

                    SqlDataReader dr = comando.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        dataGridProdutos.Rows.Add(dr["pr_codigobarras"].ToString(), dr["pr_nome"].ToString(), dr["pr_marca"].ToString(), dr["pr_precovenda"].ToString(), dr["pr_quantidade"].ToString(), dr["pr_datavalidade"].ToString(), dr["pr_estoqueminimo"].ToString(), dr["pr_imagem"].ToString(), dr["pr_obs"].ToString(), dr["pr_descricao"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Você tem certeza?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    SqlConnection conexao = con.Conectar();

                    string query = "DELETE FROM produto WHERE pr_codigobarras = @CodBarras;";

                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@CodBarras", txtCodigoBarras.Text);

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
