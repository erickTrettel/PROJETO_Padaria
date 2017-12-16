using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Padaria.Classes
{
    class Funcionario
    {

        Conexao con = new Conexao();

        private int _id;
        private string _nivelAcesso;
        private string _usuario;
        private string _nome;
        private string _sexo;
        private string _cargo;
        private string _dataNascimento;
        private string _contratacao;
        private string _endereco;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _CEP;
        private string _pais;
        private string _telefone;
        private string _email;
        private string _senha;
        private string _obs;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string NivelAcesso
        {
            get
            {
                return _nivelAcesso;
            }

            set
            {
                _nivelAcesso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
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

        public string Sexo
        {
            get
            {
                return _sexo;
            }

            set
            {
                _sexo = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _cargo;
            }

            set
            {
                _cargo = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _bairro;
            }

            set
            {
                _bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                _cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public string CEP
        {
            get
            {
                return _CEP;
            }

            set
            {
                _CEP = value;
            }
        }

        public string Pais
        {
            get
            {
                return _pais;
            }

            set
            {
                _pais = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                _telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
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

        public string DataNascimento
        {
            get
            {
                return _dataNascimento;
            }

            set
            {
                _dataNascimento = value;
            }
        }

        public string Contratacao
        {
            get
            {
                return _contratacao;
            }

            set
            {
                _contratacao = value;
            }
        }

        public string Cadastrar()
        {
            try
            {
                SqlConnection conexao = con.Conectar();

                string query = "INSERT INTO funcionario (nivelacesso, usuario, nome, sexo, cargo, nascimento, contratacao, endereco, numero, bairro, cidade, estado, CEP, pais, telefone, email, senha, obs) VALUES (@NivelAcesso, @Usuario, @Nome, @Sexo, @Cargo, @Nascimento, @Contratacao, @Endereco, @Numero, @Bairro, @Cidade, @Estado, @CEP, @Pais, @Telefone, @Email, @Senha, @OBS);";

                SqlCommand comando = new SqlCommand(query, conexao);

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@NivelAcesso", NivelAcesso);
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@Sexo", Sexo);
                comando.Parameters.AddWithValue("@Cargo", Cargo);
                comando.Parameters.AddWithValue("@Nascimento", DataNascimento);
                comando.Parameters.AddWithValue("@Contratacao", Contratacao);
                comando.Parameters.AddWithValue("@Endereco", Endereco);
                comando.Parameters.AddWithValue("@Numero", Numero);
                comando.Parameters.AddWithValue("@Bairro", Bairro);
                comando.Parameters.AddWithValue("@Cidade", Cidade);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@CEP", CEP);
                comando.Parameters.AddWithValue("@Pais", Pais);
                comando.Parameters.AddWithValue("@Telefone", Telefone);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Senha", Senha);
                comando.Parameters.AddWithValue("@OBS", Obs);

                comando.ExecuteNonQuery();

                return "Cadastro realizado com sucesso!";
                
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar funcionário: \n" + ex.Message;
            }

        }
    }
}
