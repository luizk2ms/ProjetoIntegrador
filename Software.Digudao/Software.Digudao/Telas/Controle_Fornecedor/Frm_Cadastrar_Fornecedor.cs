using prototipos.DB.Fornecedor;
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

namespace Software.Digudao.Controle_Fornecedor
{
    public partial class Frm_Cadastrar_Fornecedor : Form
    {
        public Frm_Cadastrar_Fornecedor()
        {
            InitializeComponent();
        }

        int pk;
        private void PegarIdFuncionario()
        {
            FuncionarioBusiness funcionario = new FuncionarioBusiness();
            List<FuncionarioDTO>lista=funcionario.ConsultarporCPF(mktcpf.Text);
            FuncionarioDTO dto = lista[0];
            pk = dto.Id_Funcionario;
        }
        private void SalvarFornecedor()
        {
            PegarIdFuncionario();
            FornecedorBusiness business = new FornecedorBusiness();
            FornecedorDTO dto = new FornecedorDTO();

            
            dto.Nm_nome = txtnome.Text;
            dto.tel_telefone = maskedTextBox1.Text;
            dto.uf_uf = txtuf.Text;
            dto.cnpj = maskedTextBox3.Text;
            dto.ds_descricao = textBox2.Text;
            dto.email = textBox3.Text;
            dto.en_endereco = txtendereco.Text;
            dto.br_bairro = txtbairo.Text;
            dto.cd_cidade = txtcidade.Text;
            dto.nr_numero = txtnumerocasa.Text;
            dto.pr_preco_unitario = decimal.Parse(txtprecounitario.Text);
            dto.CEP = mktcep.Text;
            dto.fk_ID_Funcionario = pk;
            dto.cel_celular = mktcelular.Text;
            business.Salvar(dto);


        }


        private void Frm_Cadastrar_Fornecedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarFornecedor();
            MessageBox.Show("Fornecedor cadastrado com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm_Consultar_Fornecedor fornecedor = new Frm_Consultar_Fornecedor();
            fornecedor.Show();
        }
    }
}
