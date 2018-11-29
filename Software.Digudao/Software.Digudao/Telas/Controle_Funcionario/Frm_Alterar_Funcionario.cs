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
    public partial class Frm_Alterar_Funcionario : Form
    {
        public Frm_Alterar_Funcionario()
        {
            InitializeComponent();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness Funcionario = new FuncionarioBusiness();
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.nm_nomefunci = textBox4.Text;
            dto.nm_numero = textBox5.Text;
            dto.tl_telefone = textBox9.Text;
            dto.cel_celular = textBox11.Text;
            dto.cpf_cpf = mktcpf.Text;
            dto.cp_cep = textBox6.Text;
            dto.cr_cargo = textBox10.Text;
            dto.ds_endereco = textBox8.Text;
            dto.dt_datadeentrada = DateTime.Parse(dateTimePicker2.Text);
            dto.dt_datasaida = DateTime.Parse(dateTimePicker1.Text);

            Funcionario.Alterar(dto);
            MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
