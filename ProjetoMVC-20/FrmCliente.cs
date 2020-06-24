using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVC_20.DAL;
using ProjetoMVC_20.BLL;
using ProjetoMVC_20.DTO;

namespace ProjetoMVC_20
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Cliente20BLL objDTO = new tbl_Cliente20BLL();
                tbl_Cliente20BLL objBLL = new tbl_Cliente20BLL();

                objDTO.cpf_cliente = txtCpf20.Text.Trim();
                objDTO.Nome_cliente = txtNome20.Text.Trim();
                objDTO.Nome_mae = txtMae20.Text.Trim();

                if (objBLL.Autenticar(objDTO.Cpf_cliente, objDTO.Nome_cliente, objDTO.nome_mae))
                {
                    MessageBox.Show("Beneficiário localizado no banco de dados");
                }
                else
                {
                    MessageBox.Show("Beneficiário não Localizado no banco de dados");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Erro: \n" + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message);
            }

        }
    }
}
