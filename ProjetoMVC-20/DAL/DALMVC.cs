using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC_20.DAL
{
    class DALMVC
    {

        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false;" +
                                        "server = localhost; " +
                                        "database = ProjetoMVCC30; " +
                                        "user = root; pwd = ;";

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas ao conectar com o banco de dados. \nErro " + e.Message);
            }

        }
    }
}
