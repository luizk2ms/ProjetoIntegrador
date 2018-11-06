﻿using Avilabombonieri.DB.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Telas.Controle_Estoque
{
    public partial class Cadastro__Estoque : Form
    {
        public Cadastro__Estoque()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EstoqueDTO dto = new EstoqueDTO();
            dto.Id_Estoque = int.Parse(IdProduto.Text);
            dto.nm_nome = NomeProd.Text;
            dto.Qn_Quantidade = Quantidade.Text;
            dto.Tm_tamanho = Tamanho.Text;
            dto.Qn_QuantidadeEmKg = QuantidadeEmKg.Text;
            dto.dt_data = DateTime.Parse(DatadeValidade.Text);
            dto.Pc_preco = decimal.Parse(Preco.Text);

            EstoqueBusiness bussines = new EstoqueBusiness();
            bussines.Cadastrar(dto);
        }
    }
}
