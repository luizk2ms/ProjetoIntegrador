using Avilabombonieri.Controle_Usuario;
using Avilabombonieri.Tela_inicio;
using Avilabombonieri.Telas.Controle_funcionarios;
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

namespace Avilabombonieri.Controle_funcionarios
{
    public partial class Cadastrar_Funcionario : Form
    {
        public Cadastrar_Funcionario()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Compra_usuario comprausuario = new Compra_usuario();
            Hide();
            comprausuario.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio Inicio = new inicio();
            Hide();
            Inicio.ShowDialog();
            Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Alterar_Funcionario alterarfuncionario = new Alterar_Funcionario();
            Hide();
            alterarfuncionario.ShowDialog();
            Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Consultar_Funcionario  consultarfuncionario = new Consultar_Funcionario();
            Hide();
            consultarfuncionario.ShowDialog();
            Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness Funcionario = new FuncionarioBusiness();
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.Id_Funcionario = int.Parse(textBox1.Text);
            dto.Nm_Nome = textBox4.Text;
            dto.cel_celular = int.Parse(textBox11.Text);
            dto.cpf_cpf = int.Parse(textBox7.Text);
            dto.cp_cep = int.Parse(textBox6.Text);
            dto.cr_cargo = textBox10.Text;
            dto.ds_endereço = textBox8.Text;
            dto.dt_datadeentrada = DateTime.Parse(dateTimePicker2.Text);
            dto.dt_datasaida = DateTime.Parse(dateTimePicker1.Text);

            Funcionario.Cadastrar(dto);
        }
    }
}
