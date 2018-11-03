using Avilabombonieri.DB.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Telas.Cadastrar_Produto
{
    public partial class Frm_Alterar_Produto : Form
    {
        public Frm_Alterar_Produto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             ProdutoDTO dto = new ProdutoDTO();
            dto.Id_Produto = int.Parse(id.Text);
            dto.Ds_Descricao = descricao.Text;
            dto.Dt_Datadevalidade = DateTime.Parse(datadeVal.Text);
            dto.Kg_kilo = kg.Text;
            dto.Ml = decimal.Parse(ml.Text);
            dto.Nm_Nome = nome.Text;
            dto.Vl_Valor = valor.Text;
            dto.Lt_litros = decimal.Parse(litros.Text);

            ProdutoBusiness bussines = new ProdutoBusiness();
            bussines.Consultar(dto);






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
