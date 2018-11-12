//namespace Avilabombonieri.Telas.Fluxo_Caixa
//{
//    partial class Frm_Fluxo_Caixa
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null))
////            {
////                components.Dispose();
////            }
////            base.Dispose(disposing);
////        }

////        #region Windows Form Designer generated code

////        /// <summary>
////        /// Required method for Designer support - do not modify
////        /// the contents of this method with the code editor.
////        /// </summary>
////        private void InitializeComponent()
////        {
////            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fluxo_Caixa));
////            this.dataGridView1 = new System.Windows.Forms.DataGridView();
////            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
////            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
////            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
////            this.Inicio = new System.Windows.Forms.Label();
////            this.Fim = new System.Windows.Forms.Label();
////            this.dtpfim = new System.Windows.Forms.DateTimePicker();
////            this.dtkinicio = new System.Windows.Forms.DateTimePicker();
////            this.label2 = new System.Windows.Forms.Label();
////            this.panel2 = new System.Windows.Forms.Panel();
////            this.button13 = new System.Windows.Forms.Button();
////            this.button12 = new System.Windows.Forms.Button();
////            this.button14 = new System.Windows.Forms.Button();
////            this.button15 = new System.Windows.Forms.Button();
////            this.button4 = new System.Windows.Forms.Button();
////            this.button2 = new System.Windows.Forms.Button();
////            this.button3 = new System.Windows.Forms.Button();
////            this.button1 = new System.Windows.Forms.Button();
////            this.pictureBox2 = new System.Windows.Forms.PictureBox();
////            this.pictureBox3 = new System.Windows.Forms.PictureBox();
////            this.pictureBox4 = new System.Windows.Forms.PictureBox();
////            this.pictureBox1 = new System.Windows.Forms.PictureBox();
////            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
////            this.panel2.SuspendLayout();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
////            this.SuspendLayout();
////            // 
////            // dataGridView1
////            // 
////            this.dataGridView1.AllowUserToAddRows = false;
////            this.dataGridView1.AllowUserToDeleteRows = false;
////            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
////            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
////            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
////            this.Column1,
////            this.Column2,
////            this.Column3});
////            this.dataGridView1.Location = new System.Drawing.Point(224, 220);
////            this.dataGridView1.Name = "dataGridView1";
////            this.dataGridView1.ReadOnly = true;
////            this.dataGridView1.Size = new System.Drawing.Size(347, 191);
////            this.dataGridView1.TabIndex = 74;
////            // 
////            // Column1
////            // 
////            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
////            this.Column1.DataPropertyName = "dt_operacao";
////            this.Column1.HeaderText = "Dia";
////            this.Column1.Name = "Column1";
////            this.Column1.ReadOnly = true;
////            // 
////            // Column2
////            // 
////            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
////            this.Column2.DataPropertyName = "to_operacao";
////            this.Column2.HeaderText = "Operação";
////            this.Column2.Name = "Column2";
////            this.Column2.ReadOnly = true;
////            // 
////            // Column3
////            // 
////            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
////            this.Column3.DataPropertyName = "vl_total";
////            this.Column3.HeaderText = "Total";
////            this.Column3.Name = "Column3";
////            this.Column3.ReadOnly = true;
////            // 
////            // Inicio
////            // 
////            this.Inicio.AutoSize = true;
////            this.Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.Inicio.ForeColor = System.Drawing.Color.Indigo;
////            this.Inicio.Location = new System.Drawing.Point(220, 120);
////            this.Inicio.Name = "Inicio";
////            this.Inicio.Size = new System.Drawing.Size(54, 24);
////            this.Inicio.TabIndex = 73;
////            this.Inicio.Text = "Inicio";
////            // 
////            // Fim
////            // 
////            this.Fim.AutoSize = true;
////            this.Fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.Fim.ForeColor = System.Drawing.Color.Indigo;
////            this.Fim.Location = new System.Drawing.Point(220, 162);
////            this.Fim.Name = "Fim";
////            this.Fim.Size = new System.Drawing.Size(42, 24);
////            this.Fim.TabIndex = 72;
////            this.Fim.Text = "Fim";
////            // 
////            // dtpfim
////            // 
////            this.dtpfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.dtpfim.Location = new System.Drawing.Point(356, 164);
////            this.dtpfim.Name = "dtpfim";
////            this.dtpfim.Size = new System.Drawing.Size(215, 20);
////            this.dtpfim.TabIndex = 71;
////            this.dtpfim.ValueChanged += new System.EventHandler(this.dtpfim_ValueChanged);
////            // 
////            // dtkinicio
////            // 
////            this.dtkinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.dtkinicio.Location = new System.Drawing.Point(356, 120);
////            this.dtkinicio.Name = "dtkinicio";
////            this.dtkinicio.Size = new System.Drawing.Size(215, 20);
////            this.dtkinicio.TabIndex = 70;
////            this.dtkinicio.ValueChanged += new System.EventHandler(this.dtkinicio_ValueChanged);
////            // 
////            // label2
////            // 
////            this.label2.AutoSize = true;
////            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.label2.ForeColor = System.Drawing.Color.Indigo;
////            this.label2.Location = new System.Drawing.Point(326, 59);
////            this.label2.Name = "label2";
////            this.label2.Size = new System.Drawing.Size(137, 24);
////            this.label2.TabIndex = 67;
////            this.label2.Text = "Fluxo de Caixa";
////            // 
////            // panel2
////            // 
////            this.panel2.BackColor = System.Drawing.Color.Indigo;
////            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
////            this.panel2.Controls.Add(this.button13);
////            this.panel2.Controls.Add(this.button12);
////            this.panel2.Controls.Add(this.button14);
////            this.panel2.Controls.Add(this.button15);
////            this.panel2.Controls.Add(this.button4);
////            this.panel2.Controls.Add(this.button2);
////            this.panel2.Controls.Add(this.button3);
////            this.panel2.Controls.Add(this.button1);
////            this.panel2.Location = new System.Drawing.Point(1, 1);
////            this.panel2.Name = "panel2";
////            this.panel2.Size = new System.Drawing.Size(752, 35);
////            this.panel2.TabIndex = 75;
////            // 
////            // button13
////            // 
////            this.button13.BackColor = System.Drawing.Color.White;
////            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
////            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.button13.ForeColor = System.Drawing.Color.Indigo;
////            this.button13.Location = new System.Drawing.Point(401, 7);
////            this.button13.Name = "button13";
////            this.button13.Size = new System.Drawing.Size(154, 23);
////            this.button13.TabIndex = 53;
////            this.button13.Text = "Folha Pagamento";
////            this.button13.UseVisualStyleBackColor = false;
////            // 
////            // button12
////            // 
////            this.button12.BackColor = System.Drawing.Color.White;
////            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
////            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.button12.ForeColor = System.Drawing.Color.Indigo;
////            this.button12.Location = new System.Drawing.Point(291, 7);
////            this.button12.Name = "button12";
////            this.button12.Size = new System.Drawing.Size(104, 23);
////            this.button12.TabIndex = 52;
////            this.button12.Text = "Fornecedor";
////            this.button12.UseVisualStyleBackColor = false;
////            // 
////            // button14
////            // 
////            this.button14.BackColor = System.Drawing.Color.White;
////            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
////            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.button14.ForeColor = System.Drawing.Color.Indigo;
////            this.button14.Location = new System.Drawing.Point(171, 7);
////            this.button14.Name = "button14";
////            this.button14.Size = new System.Drawing.Size(113, 23);
////            this.button14.TabIndex = 50;
////            this.button14.Text = "Funcionários";
////            this.button14.UseVisualStyleBackColor = false;
////            // 
////            // button15
////            // 
////            this.button15.BackColor = System.Drawing.Color.White;
////            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
////            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.button15.ForeColor = System.Drawing.Color.Indigo;
////            this.button15.Location = new System.Drawing.Point(90, 6);
////            this.button15.Name = "button15";
////            this.button15.Size = new System.Drawing.Size(75, 23);
////            this.button15.TabIndex = 49;
////            this.button15.Text = "Compras";
////            this.button15.UseVisualStyleBackColor = false;
////            // 
////            // button4
////            // 
////            this.button4.BackColor = System.Drawing.Color.White;
////            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
////            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
////            this.button4.ForeColor = System.Drawing.Color.Indigo;
////            this.button4.Location = new System.Drawing.Point(9, 6);
////            this.button4.Name = "button4";
////            this.button4.Size = new System.Drawing.Size(75, 23);
////            this.button4.TabIndex = 43;
////            this.button4.Text = "Inicio";
////            this.button4.UseVisualStyleBackColor = false;
////            // 
////            // button2
////            // 
////            this.button2.BackgroundImage = global::Avilabombonieri.Properties.Resources.minimize;
////            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.button2.Location = new System.Drawing.Point(643, 7);
////            this.button2.Name = "button2";
////            this.button2.Size = new System.Drawing.Size(33, 23);
////            this.button2.TabIndex = 43;
////            this.button2.UseVisualStyleBackColor = true;
////            // 
////            // button3
////            // 
////            this.button3.BackgroundImage = global::Avilabombonieri.Properties.Resources.Maximize;
////            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.button3.Location = new System.Drawing.Point(682, 7);
////            this.button3.Name = "button3";
////            this.button3.Size = new System.Drawing.Size(26, 23);
////            this.button3.TabIndex = 44;
////            this.button3.UseVisualStyleBackColor = true;
////            // 
////            // button1
////            // 
////            this.button1.BackColor = System.Drawing.Color.Transparent;
////            this.button1.BackgroundImage = global::Avilabombonieri.Properties.Resources.close;
////            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.button1.Location = new System.Drawing.Point(714, 7);
////            this.button1.Name = "button1";
////            this.button1.Size = new System.Drawing.Size(28, 23);
////            this.button1.TabIndex = 42;
////            this.button1.UseVisualStyleBackColor = false;
////            // 
////            // pictureBox2
////            // 
////            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
////            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.pictureBox2.Location = new System.Drawing.Point(576, 42);
////            this.pictureBox2.Name = "pictureBox2";
////            this.pictureBox2.Size = new System.Drawing.Size(168, 58);
////            this.pictureBox2.TabIndex = 89;
////            this.pictureBox2.TabStop = false;
////            // 
////            // pictureBox3
////            // 
////            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
////            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.pictureBox3.Location = new System.Drawing.Point(29, 42);
////            this.pictureBox3.Name = "pictureBox3";
////            this.pictureBox3.Size = new System.Drawing.Size(168, 58);
////            this.pictureBox3.TabIndex = 90;
////            this.pictureBox3.TabStop = false;
////            // 
////            // pictureBox4
////            // 
////            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
////            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
////            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.pictureBox4.Location = new System.Drawing.Point(29, 220);
////            this.pictureBox4.Name = "pictureBox4";
////            this.pictureBox4.Size = new System.Drawing.Size(168, 191);
////            this.pictureBox4.TabIndex = 92;
////            this.pictureBox4.TabStop = false;
////            // 
////            // pictureBox1
////            // 
////            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
////            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
////            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
////            this.pictureBox1.Location = new System.Drawing.Point(576, 220);
////            this.pictureBox1.Name = "pictureBox1";
////            this.pictureBox1.Size = new System.Drawing.Size(168, 191);
////            this.pictureBox1.TabIndex = 93;
////            this.pictureBox1.TabStop = false;
////            // 
////            // Frm_Fluxo_Caixa
////            // 
////            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
////            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
////            this.BackColor = System.Drawing.Color.White;
////            this.ClientSize = new System.Drawing.Size(754, 450);
////            this.Controls.Add(this.pictureBox1);
////            this.Controls.Add(this.pictureBox4);
////            this.Controls.Add(this.pictureBox3);
////            this.Controls.Add(this.pictureBox2);
////            this.Controls.Add(this.panel2);
////            this.Controls.Add(this.dataGridView1);
////            this.Controls.Add(this.Inicio);
////            this.Controls.Add(this.Fim);
////            this.Controls.Add(this.dtpfim);
////            this.Controls.Add(this.dtkinicio);
////            this.Controls.Add(this.label2);
////            this.ForeColor = System.Drawing.Color.Indigo;
////            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
////            this.Name = "Frm_Fluxo_Caixa";
////            this.Text = "Frm_Fluxo_Caixa";
////            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
////            this.panel2.ResumeLayout(false);
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
////            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
////            this.ResumeLayout(false);
////            this.PerformLayout();

////        }

////        #endregion

////        private System.Windows.Forms.DataGridView dataGridView1;
////        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
////        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
////        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
////        private System.Windows.Forms.Label Inicio;
////        private System.Windows.Forms.Label Fim;
////        private System.Windows.Forms.DateTimePicker dtpfim;
////        private System.Windows.Forms.DateTimePicker dtkinicio;
////        private System.Windows.Forms.Label label2;
////        private System.Windows.Forms.Panel panel2;
////        private System.Windows.Forms.Button button13;
////        private System.Windows.Forms.Button button12;
////        private System.Windows.Forms.Button button14;
////        private System.Windows.Forms.Button button15;
////        private System.Windows.Forms.Button button4;
////        private System.Windows.Forms.Button button2;
////        private System.Windows.Forms.Button button3;
////        private System.Windows.Forms.Button button1;
////        private System.Windows.Forms.PictureBox pictureBox2;
////        private System.Windows.Forms.PictureBox pictureBox3;
////        private System.Windows.Forms.PictureBox pictureBox4;
////        private System.Windows.Forms.PictureBox pictureBox1;
////    }
////}