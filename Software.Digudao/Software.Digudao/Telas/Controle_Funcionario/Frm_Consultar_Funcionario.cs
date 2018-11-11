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
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness Cliente = new FuncionarioBusiness();
            List<FuncionarioDTO> View = Cliente.ConsultarporNome(textBox2.Text);
            FuncionarioDTO dto = View[0];
            dataGridView1.DataSource = View;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
