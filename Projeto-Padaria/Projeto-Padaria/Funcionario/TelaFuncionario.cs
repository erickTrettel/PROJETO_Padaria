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

namespace Projeto_Padaria.Funcionario
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        Classes.Conexao con = new Classes.Conexao();
        string query;

        float totalVenda;

        private void GerarCodigoVenda()
        {
            SqlConnection conexao = con.Conectar();
            string StrSql = "SELECT MAX(ve_id) FROM venda";

            try
            {
                SqlCommand comando = new SqlCommand(StrSql, conexao);

                if (comando.ExecuteScalar() == DBNull.Value)
                    lblCod.Text = "1";
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    lblCod.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: "+ex.Message, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarProduto()
        {
            SqlConnection conexao = con.Conectar();
            query = "SELECT * FROM produto WHERE pr_codigobarras = '"+txtCod.Text+"'";

            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("Produto não encontrado", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCod.Clear();
                    txtCod.Focus();

                }else
                {
                    txtNome.Text = dr["pr_nome"].ToString();
                    txtValor.Text = dr["pr_precovenda"].ToString();
                    int quantidade = int.Parse(dr["pr_quantidade"].ToString());
                    lblQuantidade.Text = dr["pr_quantidade"].ToString();
                    txtQuantidade.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GravarVenda()
        {
            SqlConnection conexao = con.Conectar();

            query = "INSERT INTO venda (ve_id, ve_valor) VALUES (@VendaID, @ValorTotal)";

            SqlCommand comando = new SqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@VendaID", Convert.ToInt32(lblCod.Text));
            comando.Parameters.AddWithValue("@ValorTotal", float.Parse(txtValorCompra.Text));

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Inserir();
                dataGridViewProdutos.Rows.Clear();
                totalVenda = 0;
                txtValorCompra.Text = "0";
                txtCod.Focus();
            }

        }

        private void BaixaEstoque(string txtCod, string txtQuantidade)
        {
            SqlConnection conexao = con.Conectar();

            query = "UPDATE produto SET pr_quantidade = @Quantidade WHERE pr_codigobarras = @CodBarras;";

            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                int quantidadeProduto = int.Parse(txtQuantidade);
                int quantidadeTotal = int.Parse(lblQuantidade.Text);

                int quantidade = quantidadeTotal - quantidadeProduto;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Quantidade", quantidade);
                comando.Parameters.AddWithValue("@CodBarras", txtCod);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao dar baixa no estoque: " + ex);
            }

        }

        private void Inserir()
        {
            SqlConnection conexao = con.Conectar();

            query = "INSERT INTO itens_venda (ve_id, pr_id, iv_quantidade, iv_valortotalitem) VALUES (@VendaID, @ProdutoID, @Quantidade, @ValorTotal)";

            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@VendaID", lblCod.Text);
                    comando.Parameters.AddWithValue("@ProdutoID", dataGridViewProdutos.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@Quantidade", dataGridViewProdutos.Rows[i].Cells[3].Value);
                    comando.Parameters.AddWithValue("@ValorTotal", float.Parse(dataGridViewProdutos.Rows[i].Cells[4].Value.ToString()));

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro: " + ex);
            }

        }

        void Limpar()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            txtValor.Clear();
        }

        private void NomearDataGrid()
        {
            dataGridViewProdutos.ColumnCount = 5;
            dataGridViewProdutos.Columns[0].Name = "Código";
            dataGridViewProdutos.Columns[1].Name = "Produto";
            dataGridViewProdutos.Columns[1].Width = 250;
            dataGridViewProdutos.Columns[2].Name = "Valor Unitário";
            dataGridViewProdutos.Columns[3].Name = "Quantidade";
            dataGridViewProdutos.Columns[4].Name = "Total";

        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {
            GerarCodigoVenda();
            NomearDataGrid();
        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {
            if (txtCod.Text != string.Empty)
                ConsultarProduto();
            else
                txtCod.Focus();
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantidade.Text != string.Empty)
                txtTotal.Text = (float.Parse(txtValor.Text) * float.Parse(txtQuantidade.Text)).ToString();
            else
            {
                MessageBox.Show("Digite a quantidade", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            int quantidadeCompra = int.Parse(txtQuantidade.Text);
            int quantidadeProduto = int.Parse(lblQuantidade.Text);

            if (quantidadeProduto > quantidadeCompra)
            {
                dataGridViewProdutos.Rows.Add(txtCod.Text, txtNome.Text, txtValor.Text, txtQuantidade.Text, txtTotal.Text);
                totalVenda += float.Parse(txtTotal.Text);
                txtValorCompra.Text = totalVenda.ToString();

                BaixaEstoque(txtCod.Text, txtQuantidade.Text);
                Limpar();
                txtCod.Focus();
            }
            else
                MessageBox.Show("Estoque insuficiente", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            GravarVenda();
            GerarCodigoVenda();
        }
    }
}
