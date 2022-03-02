namespace _12MStokEkstresi
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Seciniz = new System.Windows.Forms.ComboBox();
            this.dt_VeriAktar = new System.Windows.Forms.DataGridView();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Csv = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_VeriAktar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(367, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "GÖSTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 19);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 45);
            this.dateTimePicker2.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // cb_Seciniz
            // 
            this.cb_Seciniz.FormattingEnabled = true;
            this.cb_Seciniz.Location = new System.Drawing.Point(638, 42);
            this.cb_Seciniz.Name = "cb_Seciniz";
            this.cb_Seciniz.Size = new System.Drawing.Size(121, 20);
            this.cb_Seciniz.TabIndex = 5;
            // 
            // dt_VeriAktar
            // 
            this.dt_VeriAktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_VeriAktar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiraNo,
            this.IslemTur,
            this.EvrakNo,
            this.Tarih,
            this.GirisMiktari,
            this.CikisMiktari,
            this.StokMiktari});
            this.dt_VeriAktar.Location = new System.Drawing.Point(100, 147);
            this.dt_VeriAktar.Name = "dt_VeriAktar";
            this.dt_VeriAktar.Size = new System.Drawing.Size(742, 266);
            this.dt_VeriAktar.TabIndex = 6;
            this.dt_VeriAktar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_VeriAktar_CellContentClick);
            // 
            // SiraNo
            // 
            this.SiraNo.HeaderText = "SiraNo";
            this.SiraNo.Name = "SiraNo";
            // 
            // IslemTur
            // 
            this.IslemTur.HeaderText = "IslemTur";
            this.IslemTur.Name = "IslemTur";
            // 
            // EvrakNo
            // 
            this.EvrakNo.HeaderText = "EvrakNo";
            this.EvrakNo.Name = "EvrakNo";
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // GirisMiktari
            // 
            this.GirisMiktari.HeaderText = "GirisMiktari";
            this.GirisMiktari.Name = "GirisMiktari";
            // 
            // CikisMiktari
            // 
            this.CikisMiktari.HeaderText = "CikisMiktari";
            this.CikisMiktari.Name = "CikisMiktari";
            // 
            // StokMiktari
            // 
            this.StokMiktari.HeaderText = "StokMiktari";
            this.StokMiktari.Name = "StokMiktari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(546, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seçiniz:";
            // 
            // btn_Csv
            // 
            this.btn_Csv.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Csv.Location = new System.Drawing.Point(848, 341);
            this.btn_Csv.Name = "btn_Csv";
            this.btn_Csv.Size = new System.Drawing.Size(105, 72);
            this.btn_Csv.TabIndex = 8;
            this.btn_Csv.Text = "EXCELE AKTAR";
            this.btn_Csv.UseVisualStyleBackColor = true;
            this.btn_Csv.Click += new System.EventHandler(this.btn_Csv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Seciniz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(100, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StokEkstresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_12MStokEkstresi.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Csv);
            this.Controls.Add(this.dt_VeriAktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_VeriAktar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Seciniz;
        private System.Windows.Forms.DataGridView dt_VeriAktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMiktari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Csv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

