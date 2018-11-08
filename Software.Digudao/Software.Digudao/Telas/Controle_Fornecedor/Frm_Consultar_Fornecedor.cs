using prototipos.DB.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_Fornecedor
{
    public partial class Frm_Consultar_Fornecedor : Form
    {
        public Frm_Consultar_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorBusiness Cliente = new FornecedorBusiness();
            List<FornecedorViewDTO> View = Cliente.ConsultarporNome(txtfornecedor.Text);
            FornecedorViewDTO dto = View[0];
            dgvfornecedor.DataSource = View;
        }
    }
}
