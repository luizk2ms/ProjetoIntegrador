using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Digudao.Fluxo_caixa
{
    public partial class FluxoDeCaixa : Form
    {
        public FluxoDeCaixa()
        {
            InitializeComponent();
            loadFluxoCaixa(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        void loadFluxoCaixa(DateTime start, DateTime end)
        {
            FluxodeCaixaBusiness nha = new FluxodeCaixaBusiness();
            List<FluxodeCaixaView> item = nha.FiltrarData(start, end);
            dataGridView1.DataSource = item;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula", "Back's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula", "Back's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtkinicio_ValueChanged(object sender, EventArgs e)
        {
            loadFluxoCaixa(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        private void dtpfim_ValueChanged(object sender, EventArgs e)
        {
            loadFluxoCaixa(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio iniciar = new Inicio();
            Hide();
            iniciar.ShowDialog();
            Show();
        }
    }
}
