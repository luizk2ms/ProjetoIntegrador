using Avilabombonieri.DB.Fluxo_caixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avilabombonieri.Telas.Fluxo_Caixa
{
    public partial class Frm_Fluxo_Caixa : Form
    {
        public Frm_Fluxo_Caixa()
        {
            InitializeComponent();
           LoadFrm_Fluxo_Caixa(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        private void LoadFrm_Fluxo_Caixa(DateTime date, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

      

        void loadFluxoCaixa(DateTime start, DateTime end)
        {
            Fluxo_BUSSINES fluxo_BUSSINES = new Fluxo_BUSSINES();
            List<Fluxo_View> item = fluxo_BUSSINES.FiltrarData(start, end);
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
            loadFr(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        private void loadFr(DateTime date, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        private void dtpfim_ValueChanged(object sender, EventArgs e)
        {
            loadFrm_Fluxo_Caixa(dtkinicio.Value.Date, dtpfim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
        }

        private void loadFrm_Fluxo_Caixa(DateTime date, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
