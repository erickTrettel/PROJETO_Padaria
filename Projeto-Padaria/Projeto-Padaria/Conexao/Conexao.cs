using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Padaria.Conexao
{
    class Conexao
    {
        string _strConexao;

        public void Conectar()
        {
            _strConexao = Properties.Settings.Default.BD_Padaria;
            SqlConnection conexao = new SqlConnection(_strConexao);
            conexao.Open();
        }
    }
}
