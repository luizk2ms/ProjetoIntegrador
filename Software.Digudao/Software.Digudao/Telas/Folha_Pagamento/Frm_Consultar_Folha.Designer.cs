namespace Software.Digudao.Telas.Folha_Pagamento
{
    partial class Frm_Consultar_Folha
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
            this.dgvFolha = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolha)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFolha
            // 
            this.dgvFolha.AllowUserToAddRows = false;
            this.dgvFolha.AllowUserToDeleteRows = false;
            this.dgvFolha.ColumnHeadersHeight = 40;
            this.dgvFolha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFolha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvFolha.Location = new System.Drawing.Point(33, 102);
            this.dgvFolha.Name = "dgvFolha";
            this.dgvFolha.ReadOnly = true;
            this.dgvFolha.RowHeadersVisible = false;
            this.dgvFolha.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFolha.RowTemplate.Height = 30;
            this.dgvFolha.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFolha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFolha.Size = new System.Drawing.Size(699, 288);
            this.dgvFolha.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nm_NomeFunc";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ds_CPF";
            this.Column2.HeaderText = "CPF";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ds_Cargo";
            this.Column3.HeaderText = "Função";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "vl_SalarioBruto";
            this.Column4.HeaderText = "Salário Bruto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "ds_DiasTrabalhados";
            this.Column5.HeaderText = "Dias Trabalhados";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(145, 405);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(151, 20);
            this.txtCPF.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(29, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "CPF :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button6.Location = new System.Drawing.Point(324, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 49;
            this.button6.Text = "Consultar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 36);
            this.panel2.TabIndex = 50;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::Software.Digudao.Properties.Resources.minimize;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Transparent;
            this.button12.Location = new System.Drawing.Point(736, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(33, 23);
            this.button12.TabIndex = 56;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImage = global::Software.Digudao.Properties.Resources.close_md;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.Color.Transparent;
            this.button14.Location = new System.Drawing.Point(775, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 23);
            this.button14.TabIndex = 55;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(9, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(195, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 76;
            this.label2.Text = "Consultar Folha Pagamento";
            // 
            // Frm_Consultar_Folha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dgvFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Consultar_Folha";
            this.Text = "Frm_Consultar_Folha";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolha)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}