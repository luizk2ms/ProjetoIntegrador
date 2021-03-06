﻿using prototipos.DB.Funcionario;
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
            dto.nm_empresa = textBox2.Text;
            Funcionario.Cadastrar(dto);

        }


        private void button7_Click(object sender, EventArgs e)
        {
            CarregarFuncionario();
            MessageBox.Show("Funcionario cadastrado com sucesso!", "digudão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Funcionario consultarfuncionario = new Frm_Consultar_Funcionario();
           consultarfuncionario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void Frm_Cadastra_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
