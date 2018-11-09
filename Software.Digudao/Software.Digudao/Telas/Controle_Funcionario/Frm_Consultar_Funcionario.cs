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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Frm_Alterar_Funcionario alterarcliente = new Frm_Alterar_Funcionario();
                FuncionarioViewDTO dto = dataGridView1.CurrentRow.DataBoundItem as FuncionarioViewDTO;
                int Id_Funcionario = dto.Id_Funcionario;
                string Nm_Nome;
                Id_Funcionario = dto.Id_Funcionario;
                Nm_Nome = dto.Nm_Nome;
                alterarcliente.LoadScreen(Id_Funcionario, Nm_Nome);
                alterarcliente.Show();

            }
            if (e.ColumnIndex == 8)
            {
                FuncionarioBusiness Cliente = new FuncionarioBusiness();
                FuncionarioViewDTO dto = dataGridView1.CurrentRow.DataBoundItem as FuncionarioViewDTO;
                Cliente.Remover(dto.Id_Funcionario);
                ();


            }
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
