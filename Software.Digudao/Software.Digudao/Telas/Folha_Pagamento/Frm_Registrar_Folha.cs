﻿using Software.Digudao.DB.Folha_de_Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Folha_Pagamento
{
    public partial class Frm_Registrar_Folha : Form
    {
        public Frm_Registrar_Folha()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Folha_de_Pagamento_DTO dto = new Folha_de_Pagamento_DTO();
                dto.cr_cargo = textBox4.Text;
                dto.ds_diastrabalhados = textBox5.Text == string.Empty ? 0 : Convert.ToInt32(textBox5.Text);
                dto.ds_horae = textBox6.Text == string.Empty ? 0 : Convert.ToInt32(textBox6.Text);
                dto.ds_horas = textBox7.Text == string.Empty ? 0 : Convert.ToInt32(textBox7.Text);
                dto.id_Funcionario = Funcionario.id_funcionario;
                dto.vl_salarioBruto = textBox8.Text == string.Empty ? 0 : Convert.ToDecimal(textBox8.Text);

                Folha_de_Pagamento_Business business = new Folha_de_Pagamento_Business();
                business.SalvarFolha(dto);
               

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

        private void Frm_Registrar_Folha_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
