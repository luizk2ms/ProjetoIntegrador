//using prototipos.DB.Fornecedor;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Software.Digudao.Controle_Fornecedor
//{
//    public partial class Frm_Alterar_Fornecedor : Form
//    {
//        public Frm_Alterar_Fornecedor()
//        {
//            InitializeComponent();
//        }
//        private void AlterarFornecedor()
//        {
//            FornecedorBusiness business = new FornecedorBusiness();
//            FornecedorDTO dto = new FornecedorDTO();

//            dto.Id_Fornecedor = int.Parse(textBox11.Text);
//            dto.id_produto = int.Parse(textBox12.Text);
//            dto.Nm_nome = txtnome.Text;
//            dto.Nm_numero = int.Parse(textBox8.Text);
//            dto.tel_contem = int.Parse(maskedTextBox1.Text);
//            dto.uf_uf = txtuf.Text;
//            dto.cel_celular = int.Parse(maskedTextBox4.Text);
//            dto.cnpj = int.Parse(maskedTextBox3.Text);
//            dto.ds_descricao = textBox2.Text;
//            dto.el_email = textBox3.Text;
//            dto.en_endereço = textBox5.Text;
            

//            business.Alterar(dto);


//        }
//        private void Carregarcampos()
//        {
//            FornecedorBusiness business = new FornecedorBusiness();
//            List<FornecedorDTO> lista = business.ConsultarporNome(tex);
//            FornecedorDTO dto = lista[0];
//            dto.Id_Fornecedor = int.Parse(textBox11.Text);
//            dto.id_produto = int.Parse(textBox12.Text);
//            dto.Nm_nome = txtnome.Text;
//            dto.Nm_numero = int.Parse(textBox8.Text);
//            dto.tel_contem = int.Parse(maskedTextBox1.Text);
//            dto.uf_uf = txtuf.Text;
//            dto.cel_celular = int.Parse(maskedTextBox4.Text);
//            dto.cnpj = int.Parse(maskedTextBox3.Text);
//            dto.ds_descricao = textBox2.Text;
//            dto.el_email = textBox3.Text;
//            dto.en_endereço = textBox5.Text;


//        }
        

//        private void button1_Click(object sender, EventArgs e)
//        {
//            AlterarFornecedor();
//            MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnInicio_Click(object sender, EventArgs e)
//        {
            
//        }
//    }

//}
