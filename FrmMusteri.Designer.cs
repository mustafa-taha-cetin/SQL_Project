namespace Proje_SQL
{
    partial class FrmMusteri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(171)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 128);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 66F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 135);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müsteriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(525, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 556);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müsteri Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(265, 166);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 48);
            this.txtId.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(265, 227);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(219, 48);
            this.txtAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müsteri Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(265, 288);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(219, 48);
            this.txtSoyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Müsteri Soyad:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(265, 416);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(219, 48);
            this.txtBakiye.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bakiye:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şehir:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.btnListele.Location = new System.Drawing.Point(46, 494);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(211, 48);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.btnEkle.Location = new System.Drawing.Point(275, 494);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(211, 48);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(178)))), ((int)(((byte)(152)))));
            this.btnSil.Location = new System.Drawing.Point(275, 554);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(211, 48);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.btnGuncelle.Location = new System.Drawing.Point(46, 554);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(211, 48);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(208)))), ((int)(((byte)(182)))));
            this.btnAra.Location = new System.Drawing.Point(353, 644);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(116, 48);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(128, 647);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(219, 48);
            this.txtBul.TabIndex = 17;
            this.txtBul.TextChanged += new System.EventHandler(this.txtBul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bul:";
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(265, 355);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(219, 48);
            this.cmbSehir.TabIndex = 19;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1125, 749);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteri";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSehir;
    }
}