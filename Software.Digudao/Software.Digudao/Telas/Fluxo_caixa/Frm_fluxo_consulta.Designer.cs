//namespace Software.Digudao.Fluxo_caixa
//{
//    partial class Frm_fluxo_consulta
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.button5 = new System.Windows.Forms.Button();
//            this.label2 = new System.Windows.Forms.Label();
//            this.dtg_consultarproduto = new System.Windows.Forms.DataGridView();
//            this.NúmeroCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.QntVendasAVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.QntVendasCartão = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.ValorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Diário = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Mensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.button9 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dtg_consultarproduto)).BeginInit();
//            this.panel2.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // button5
//            // 
//            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button5.ForeColor = System.Drawing.Color.RoyalBlue;
//            this.button5.Location = new System.Drawing.Point(179, 403);
//            this.button5.Name = "button5";
//            this.button5.Size = new System.Drawing.Size(441, 41);
//            this.button5.TabIndex = 76;
//            this.button5.Text = "Consultar";
//            this.button5.UseVisualStyleBackColor = true;
//            this.button5.Click += new System.EventHandler(this.button5_Click);
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
//            this.label2.Location = new System.Drawing.Point(223, 33);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(342, 32);
//            this.label2.TabIndex = 75;
//            this.label2.Text = "Consultar Fluxo de Caixa";
//            // 
//            // dtg_consultarproduto
//            // 
//            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            this.dtg_consultarproduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
//            this.dtg_consultarproduto.BackgroundColor = System.Drawing.Color.White;
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dtg_consultarproduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
//            this.dtg_consultarproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dtg_consultarproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.NúmeroCaixa,
//            this.QntVendasAVista,
//            this.QntVendasCartão,
//            this.ValorRecebido,
//            this.Diário,
//            this.Mensal});
//            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(138)))), ((int)(((byte)(99)))));
//            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.dtg_consultarproduto.DefaultCellStyle = dataGridViewCellStyle9;
//            this.dtg_consultarproduto.GridColor = System.Drawing.Color.Indigo;
//            this.dtg_consultarproduto.Location = new System.Drawing.Point(79, 68);
//            this.dtg_consultarproduto.Name = "dtg_consultarproduto";
//            this.dtg_consultarproduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
//            this.dtg_consultarproduto.Size = new System.Drawing.Size(643, 329);
//            this.dtg_consultarproduto.TabIndex = 74;
//            // 
//            // NúmeroCaixa
//            // 
//            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
//            this.NúmeroCaixa.DefaultCellStyle = dataGridViewCellStyle3;
//            this.NúmeroCaixa.HeaderText = "NúmeroCaixa";
//            this.NúmeroCaixa.Name = "NúmeroCaixa";
//            // 
//            // QntVendasAVista
//            // 
//            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
//            this.QntVendasAVista.DefaultCellStyle = dataGridViewCellStyle4;
//            this.QntVendasAVista.HeaderText = "QntVendasAVista";
//            this.QntVendasAVista.Name = "QntVendasAVista";
//            // 
//            // QntVendasCartão
//            // 
//            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
//            this.QntVendasCartão.DefaultCellStyle = dataGridViewCellStyle5;
//            this.QntVendasCartão.HeaderText = "QntVendasCartão";
//            this.QntVendasCartão.Name = "QntVendasCartão";
//            // 
//            // ValorRecebido
//            // 
//            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
//            this.ValorRecebido.DefaultCellStyle = dataGridViewCellStyle6;
//            this.ValorRecebido.HeaderText = "ValorRecebido";
//            this.ValorRecebido.Name = "ValorRecebido";
//            // 
//            // Diário
//            // 
//            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
//            this.Diário.DefaultCellStyle = dataGridViewCellStyle7;
//            this.Diário.HeaderText = "Diário";
//            this.Diário.Name = "Diário";
//            // 
//            // Mensal
//            // 
//            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
//            this.Mensal.DefaultCellStyle = dataGridViewCellStyle8;
//            this.Mensal.HeaderText = "Mensal";
//            this.Mensal.Name = "Mensal";
//            // 
//            // panel2
//            // 
//            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
//            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
//            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
//            this.panel2.Controls.Add(this.button9);
//            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
//            this.panel2.Location = new System.Drawing.Point(0, 0);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(819, 36);
//            this.panel2.TabIndex = 85;
//            // 
//            // button9
//            // 
//            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
//            this.button9.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold);
//            this.button9.ForeColor = System.Drawing.Color.RoyalBlue;
//            this.button9.Location = new System.Drawing.Point(9, 5);
//            this.button9.Name = "button9";
//            this.button9.Size = new System.Drawing.Size(75, 23);
//            this.button9.TabIndex = 5;
//            this.button9.Text = "Inicio";
//            this.button9.UseVisualStyleBackColor = true;
//            this.button9.Click += new System.EventHandler(this.button9_Click);
//            // 
//            // Frm_fluxo_consulta
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.White;
//            this.ClientSize = new System.Drawing.Size(817, 450);
//            this.Controls.Add(this.panel2);
//            this.Controls.Add(this.button5);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.dtg_consultarproduto);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "Frm_fluxo_consulta";
//            this.Text = "Frm_fluxo_consulta";
//            this.Load += new System.EventHandler(this.Frm_fluxo_consulta_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dtg_consultarproduto)).EndInit();
//            this.panel2.ResumeLayout(false);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button button5;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.DataGridView dtg_consultarproduto;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Button button9;
//        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroCaixa;
//        private System.Windows.Forms.DataGridViewTextBoxColumn QntVendasAVista;
//        private System.Windows.Forms.DataGridViewTextBoxColumn QntVendasCartão;
//        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRecebido;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Diário;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Mensal;
//    }
//}