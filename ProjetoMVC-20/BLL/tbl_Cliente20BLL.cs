using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ProjetoMVC_20.DAL;

namespace ProjetoMVC_20.BLL
{
    class tbl_Cliente20BLL
    {
        private DALMVC DaoBanco = new DALMVC();
        public Boolean Autenticar(string cpf, string nome, string mae)
        {
            string consulta = string.Format($@"select * from tbl_clienteC30 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{mae}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
