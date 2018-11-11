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
            dgvfuncionario.AutoGenerateColumns = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness funcionario = new FuncionarioBusiness();
            List<FuncionarioDTO> View = funcionario.ConsultarporNome(textBox2.Text);
            //FuncionarioDTO dto = View[0];
            dgvfuncionario.DataSource = View;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Consultar_Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
