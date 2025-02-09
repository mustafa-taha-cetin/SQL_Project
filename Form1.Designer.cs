namespace Proje_SQL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnKullanıcı = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(165)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 164);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 19);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hepsi Orada Firma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCıkıs);
            this.groupBox1.Controls.Add(this.btnKullanıcı);
            this.groupBox1.Controls.Add(this.btnIslem);
            this.groupBox1.Controls.Add(this.btnIstatistik);
            this.groupBox1.Controls.Add(this.btnKasa);
            this.groupBox1.Controls.Add(this.btnPersoneller);
            this.groupBox1.Controls.Add(this.btnKategoriler);
            this.groupBox1.Controls.Add(this.btnMusteriler);
            this.groupBox1.Controls.Add(this.btnUrunler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 569);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.DarkGray;
            this.btnCıkıs.Location = new System.Drawing.Point(46, 500);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(248, 49);
            this.btnCıkıs.TabIndex = 9;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Location = new System.Drawing.Point(46, 445);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(248, 49);
            this.btnKullanıcı.TabIndex = 8;
            this.btnKullanıcı.Text = "Şifre ve Kullanıcı";
            this.btnKullanıcı.UseVisualStyleBackColor = true;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(46, 390);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(248, 49);
            this.btnIslem.TabIndex = 7;
            this.btnIslem.Text = "İşlemler";
            this.btnIslem.UseVisualStyleBackColor = true;
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(46, 335);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(248, 49);
            this.btnIstatistik.TabIndex = 6;
            this.btnIstatistik.Text = "İstatistikler";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            // 
            // btnKasa
            // 
            this.btnKasa.Location = new System.Drawing.Point(46, 280);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(248, 49);
            this.btnKasa.TabIndex = 5;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(46, 225);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(248, 49);
            this.btnPersoneller.TabIndex = 4;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(46, 170);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(248, 49);
            this.btnKategoriler.TabIndex = 3;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(46, 115);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(248, 49);
            this.btnMusteriler.TabIndex = 2;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(46, 60);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(248, 49);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kontrol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(377, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 569);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kontrol";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(71, 76);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(349, 308);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(114)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1109, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnKullanıcı;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

