using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Padaria.Classes
{
    class Conexao
    {
        private string _strConexao;

        public SqlConnection Conectar()
        {
            _strConexao = Properties.Settings.Default.BD_Padaria;
            SqlConnection conexao = new SqlConnection(_strConexao);
            conexao.Open();

            return conexao;
        }
    }
}
