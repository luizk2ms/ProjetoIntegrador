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
            try
            {
                FuncionarioBusiness Funcionario = new FuncionarioBusiness();
                FuncionarioDTO dto = new FuncionarioDTO();

                dto.nm_nomefunci = textBox4.Text;
                dto.nm_numero = textBox5.Text;
                dto.tl_empresa = textBox9.Text;
                dto.cel_celular = textBox11.Text;
                dto.cpf_cpf = textBox7.Text;
                dto.cp_cep = textBox6.Text;
                dto.cr_cargo = textBox10.Text;
                dto.ds_endereço = textBox8.Text;
                dto.dt_datadeentrada = DateTime.Parse(dateTimePicker2.Text);
                dto.dt_datasaida = DateTime.Parse(dateTimePicker1.Text);
                dto.Nomedaempresa = textBox2.Text;

                Funcionario.Cadastrar(dto);

                MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
