namespace Software.Digudao.Fluxo_caixa
{
    partial class Frm_fluxo_consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_consultarproduto = new System.Windows.Forms.DataGridView();
            this.NúmeroCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntVendasAVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntVendasCartão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consultarproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Indigo;
            this.button5.Location = new System.Drawing.Point(152, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(510, 41);
            this.button5.TabIndex = 76;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(223, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 75;
            this.label2.Text = "Consultar Fluxo de Caixa";
            // 
            // dtg_consultarproduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            this.dtg_consultarproduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_consultarproduto.BackgroundColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_consultarproduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_consultarproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_consultarproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NúmeroCaixa,
            this.QntVendasAVista,
            this.QntVendasCartão,
            this.ValorRecebido,
            this.Diário,
            this.Mensal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_consultarproduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_consultarproduto.GridColor = System.Drawing.Color.Indigo;
            this.dtg_consultarproduto.Location = new System.Drawing.Point(79, 55);
            this.dtg_consultarproduto.Name = "dtg_consultarproduto";
            this.dtg_consultarproduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtg_consultarproduto.Size = new System.Drawing.Size(643, 329);
            this.dtg_consultarproduto.TabIndex = 74;
            // 
            // NúmeroCaixa
            // 
            this.NúmeroCaixa.HeaderText = "NúmeroCaixa";
            this.NúmeroCaixa.Name = "NúmeroCaixa";
            // 
            // QntVendasAVista
            // 
            this.QntVendasAVista.HeaderText = "QntVendasAVista";
            this.QntVendasAVista.Name = "QntVendasAVista";
            // 
            // QntVendasCartão
            // 
            this.QntVendasCartão.HeaderText = "QntVendasCartão";
            this.QntVendasCartão.Name = "QntVendasCartão";
            // 
            // ValorRecebido
            // 
            this.ValorRecebido.HeaderText = "ValorRecebido";
            this.ValorRecebido.Name = "ValorRecebido";
            // 
            // Diário
            // 
            this.Diário.HeaderText = "Diário";
            this.Diário.Name = "Diário";
            // 
            // Mensal
            // 
            this.Mensal.HeaderText = "Mensal";
            this.Mensal.Name = "Mensal";
            // 
            // Frm_fluxo_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_consultarproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_fluxo_consulta";
            this.Text = "Frm_fluxo_consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_consultarproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_consultarproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntVendasAVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntVendasCartão;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensal;
    }
}