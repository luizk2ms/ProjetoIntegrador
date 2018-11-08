using prototipos.DB.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Controle_compra
{
    public partial class Frm_Alterar_Compra : Form
    {
        public Frm_Alterar_Compra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void SalvarDadosdoJogador()
        {
            PedidoBusiness jogadores = new PedidoBusiness();
            PedidoDTO dto = new PedidoDTO();
            try
            {
                dto.Cliente_id_cliente = int.Parse(textBox2.Text);
                dto.Id_Pedido = int.Parse(textBox4.Text);
                dto.id_produto = int.Parse(textBox6.Text);
                dto.pc_preçoporcaixa_caixa = int.Parse(textBox5.Text);
                

             MessageBox.Show("Folha de Pagamento criada com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro não identificado: " + ex.Message, "digudão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
