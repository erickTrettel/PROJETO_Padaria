using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Padaria.Classes
{
    class Produto
    {
        Conexao con = new Conexao();

        private string _codigoBarras;
        private string _nome;
        private string _marca;
        private string _descricao;
        private float _precoVenda;
        private string _imagem;
        private int _estoqueMinimo;
        private int _quantidade;
        private string _dataValidade;
        private string _obs;

        public string CodigoBarras
        {
            get
            {
                return _codigoBarras;
            }

            set
            {
                _codigoBarras = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }

        public float PrecoVenda
        {
            get
            {
                return _precoVenda;
            }

            set
            {
                _precoVenda = value;
            }
        }

        public string Imagem
        {
            get
            {
                return _imagem;
            }

            set
            {
                _imagem = value;
            }
        }

        public int EstoqueMinimo
        {
            get
            {
                return _estoqueMinimo;
            }

            set
            {
                _estoqueMinimo = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

            set
            {
                _quantidade = value;
            }
        }

        public string DataValidade
        {
            get
            {
                return _dataValidade;
            }

            set
            {
                _dataValidade = value;
            }
        }

        public string Obs
        {
            get
            {
                return _obs;
            }

            set
            {
                _obs = value;
            }
        }

        public string Cadastrar()
        {
            try
            {
                SqlConnection conexao = con.Conectar();

                string query = "INSERT INTO produto (pr_codigobarras, pr_nome, pr_marca, pr_descricao, pr_precovenda, pr_imagem, pr_estoqueminimo, pr_quantidade, pr_datavalidade, pr_obs) VALUES (@CodigoBarras, @Nome, @Marca, @Descricao, @PrecoVenda, @Imagem, @Estoque, @Quantidade, @DataValidade, @OBS);";

                SqlCommand comando = new SqlCommand(query, conexao);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CodigoBarras", Convert.ToInt32(CodigoBarras));
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@Descricao", Descricao);
                comando.Parameters.AddWithValue("@PrecoVenda", PrecoVenda);
                comando.Parameters.AddWithValue("@Imagem", Imagem);
                comando.Parameters.AddWithValue("@Estoque", EstoqueMinimo);
                comando.Parameters.AddWithValue("@Quantidade", Quantidade);
                comando.Parameters.AddWithValue("@DataValidade", DataValidade);
                comando.Parameters.AddWithValue("@OBS", Obs);

                comando.ExecuteNonQuery();

                return "Produto cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar produto!\n" + ex;
            }
        }

        public string Editar()
        {
            SqlConnection conexao = con.Conectar();

            string query = "UPDATE produto SET pr_nome = @Nome, pr_precovenda = @Preco, pr_estoqueminimo = @Estoque, pr_descricao = @Descricao, pr_marca = @Marca, pr_quantidade = @Quantidade, pr_datavalidade = @DataValidade, pr_obs = @Obs WHERE pr_codigobarras = @CodBarras;";

            try
            {
                SqlCommand comando = new SqlCommand(query, conexao);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@Preco", PrecoVenda);
                comando.Parameters.AddWithValue("@Estoque", EstoqueMinimo);
                comando.Parameters.AddWithValue("@Descricao", Descricao);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@Quantidade", Quantidade);
                comando.Parameters.AddWithValue("@DataValidade", DataValidade);
                comando.Parameters.AddWithValue("@Obs", Obs);
                comando.Parameters.AddWithValue("@CodBarras", Convert.ToInt32(CodigoBarras));

                comando.ExecuteNonQuery();

                return "Produto editado com sucesso";
            }
            catch (Exception ex)
            {
                return "Erro ao editar produto: " + ex.Message;
            }
        }

    }
}
