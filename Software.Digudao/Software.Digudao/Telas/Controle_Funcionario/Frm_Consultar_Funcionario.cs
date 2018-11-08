using prototipos.DB.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_Funcionario
{
    public partial class Frm_Consultar_Funcionario : Form
    {
        public Frm_Consultar_Funcionario()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness Cliente = new FuncionarioBusiness();
            List<FuncionarioViewDTO> View = Cliente.ConsultarporNome(textBox2.Text);
            FuncionarioViewDTO dto = View[0];
            dataGridView1.DataSource = View;
        }
    }
}
