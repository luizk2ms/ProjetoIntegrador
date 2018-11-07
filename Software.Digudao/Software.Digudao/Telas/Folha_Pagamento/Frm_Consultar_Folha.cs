using Software.Digudao.DB.Folha_de_Pagamento;
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
    public partial class Frm_Consultar_Folha : Form
    {
        public Frm_Consultar_Folha()
        {
            InitializeComponent();
        }
        public void CarregarCampos(string id)
        {
            lblCod.Text = id;

            Folha_de_Pagamento_Business business = new Folha_de_Pagamento_Business();
            Folha_de_Pagamento_View_DTO folha = business(id);

            lblNome.Text = folha.Nm_Nome;
            lblFuncao.Text = folha.cr_cargo;
            lblDiasTrabalhados.Text = folha.ds_diastrabalhados.ToString();
            lblSalario.Text = Math.Round(folha.vl_salarioBruto, 2).ToString();

            decimal mes_valor = Mes_Valor(folha.vl_salarioBruto, 31, folha.ds_diastrabalhados);
            decimal valor_trab_50 = Valor_Trab_50(folha.ds_horae, Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_salarioBruto))));
            decimal valor_trab_100 = Valor_Trab_100(folha.ds_horas, Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_salarioBruto))));
            decimal deducao_ir = Deducao_IR(folha.vl_salarioBruto);

            decimal totalDeProventos = Math.Round(mes_valor + valor_trab_50 + valor_trab_100 + deducao_ir, 2);
            lblVencimentos.Text = totalDeProventos.ToString();

            decimal totalDeDescontos = Math.Round(ValorINSS(folha.vl_salarioBruto) + ValorFGTS(folha.vl_salarioBruto) + ValorFinar_IR(ValorIR(folha.vl_salarioBruto), Deducao_IR(folha.vl_salarioBruto)) + ValorIR(folha.vl_salarioBruto) + ValorVR(folha.vl_salarioBruto) + ValorVT(folha.vl_salarioBruto), 2);
            lblDescontos.Text = totalDeDescontos.ToString();

            decimal totalLiquido = Math.Round(totalDeProventos - totalDeDescontos, 2);
            lblReceber.Text = totalLiquido.ToString();

            lblValeTransporte.Text = Math.Round(ValorVT(folha.vl_salarioBruto), 2).ToString();
            lblValeRefeicao.Text = Math.Round(ValorVR(folha.vl_salarioBruto), 2).ToString();
            lblINSS.Text = Math.Round(ValorINSS(folha.vl_salarioBruto), 2).ToString();
            lblHoraE50.Text = Math.Round(Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_salarioBruto))), 2).ToString();
            lblHoraE100.Text = Math.Round(Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_salarioBruto))), 2).ToString();
            lblMensagem.Text = folha.ob_observacao;

            lblSalarioBase.Text = Math.Round(folha.vl_salarioBruto, 2).ToString();
            lblINSSBase.Text = Math.Round(ValorINSS(folha.vl_salarioBruto), 2).ToString();
            lblFGTSBase.Text = Math.Round(ValorFGTS(folha.vl_salarioBruto), 2).ToString();
            lblFGTSMes.Text = Math.Round(ValorFGTS(folha.vl_salarioBruto), 2).ToString();
            lblBaseIRRF.Text = Math.Round(ValorIR(folha.vl_salarioBruto), 2).ToString();
            lblFaixaIRRF.Text = Math.Round(Deducao_IR(folha.vl_salarioBruto), 2).ToString();
        }

        private decimal Mes_Valor(decimal SalarioBruto, int DiasMesAtual, int DiasMesTrabalhado)
        {
            decimal resultado = (SalarioBruto / DiasMesAtual) * DiasMesTrabalhado;
            return resultado;
        }

        private decimal Valor_Hora(decimal SalarioBruto)
        {
            decimal resultado = SalarioBruto / 220;
            return resultado;
        }

        private decimal Valor_Hora_50(double ValorHora)
        {
            double resultado = ValorHora + (ValorHora * 0.5);
            return Convert.ToDecimal(resultado);
        }

        private decimal Valor_Hora_100(double ValorHora)
        {
            double resultado = ValorHora + (ValorHora * 1);
            return Convert.ToDecimal(resultado);
        }

        private decimal Valor_Trab_50(decimal HorasTrab50, decimal ValorHora50)
        {
            decimal resultado = HorasTrab50 * ValorHora50;
            return resultado;
        }

        private decimal Valor_Trab_100(decimal HorasTrab100, decimal ValorHora100)
        {
            decimal resultado = HorasTrab100 * ValorHora100;
            return resultado;
        }

        private decimal ValorINSS(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            decimal taxa = db.TaxaINSS(SalarioBase);

            decimal resultado = (taxa / 100) * SalarioBase;
            return Math.Round(resultado, 2);
        }

        private decimal ValorIR(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            decimal taxa = db.TaxaIR(SalarioBase);

            decimal resultado = (taxa / 100) * SalarioBase;
            return Math.Round(resultado, 2);
        }

        private decimal Deducao_IR(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            decimal resultado = Math.Round(db.DeducaoIR(SalarioBase), 2);
            return resultado;
        }

        private decimal ValorFinar_IR(decimal ValorIR, decimal DecucaoIR)
        {
            decimal resultado = ValorIR - DecucaoIR;
            return resultado;
        }

        private decimal ValorFGTS(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            List<Desconto_DTO> taxas = db.Descontos();
            Desconto_DTO taxa = taxas.ElementAt(2);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }

        private decimal ValorVR(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            List<Desconto_DTO> taxas = db.Descontos();
            Desconto_DTO taxa = taxas.ElementAt(1);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }

        private decimal ValorVT(decimal SalarioBase)
        {
            Folha_de_Pagamento_Database db = new Folha_de_Pagamento_Database();
            List<Desconto_DTO> taxas = db.Descontos();
            Desconto_DTO taxa = taxas.ElementAt(0);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
