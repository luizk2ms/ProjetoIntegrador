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
    public partial class Frm_Cadastra_Funcionario : Form
    {
        public Frm_Cadastra_Funcionario()
        {
            InitializeComponent();
        }
        public void CarregarFuncionario()

        {
            FuncionarioBusiness Funcionario = new FuncionarioBusiness();
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.Id_Funcionario = int.Parse(textBox1.Text);
            dto.Nm_Nome = textBox4.Text;
            dto.nm_numero = int.Parse(textBox5.Text);
            dto.tl_empresa = int.Parse(textBox9.Text);
            dto.cel_celular = int.Parse(textBox11.Text);
            dto.cpf_cpf = int.Parse(textBox7.Text);
            dto.cp_cep = int.Parse(textBox6.Text);
            dto.cr_cargo = textBox10.Text;
            dto.ds_endereço = textBox8.Text;
            dto.dt_datadeentrada = DateTime.Parse(dateTimePicker2.Text);
            dto.dt_datasaida = DateTime.Parse(dateTimePicker1.Text);

            Funcionario.Cadastrar(dto);


        }


        private void button7_Click(object sender, EventArgs e)
        {
            CarregarFuncionario();
            MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
