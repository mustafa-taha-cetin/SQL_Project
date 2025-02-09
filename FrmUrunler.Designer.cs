namespace Proje_SQL
{
    partial class FrmUrunler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.lblKontrol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 141);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(880, 122);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Kontrol Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kontrol:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 532);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.txtDurum);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 551);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(196, 246);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(209, 57);
            this.cmbKategori.TabIndex = 4;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtDurum
            // 
            this.txtDurum.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurum.Location = new System.Drawing.Point(196, 430);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(209, 56);
            this.txtDurum.TabIndex = 7;
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStok.Location = new System.Drawing.Point(196, 369);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(209, 56);
            this.txtStok.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.Location = new System.Drawing.Point(196, 309);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(209, 56);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarka.Location = new System.Drawing.Point(196, 189);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(209, 56);
            this.txtMarka.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(196, 127);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(209, 56);
            this.txtAd.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(196, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(209, 56);
            this.txtId.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(180, 496);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(165, 49);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label9.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 61);
            this.label9.TabIndex = 8;
            this.label9.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label8.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 61);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label7.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 61);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label6.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 61);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 61);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 61);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Id:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnListele.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(22, 730);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(249, 59);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnEkle.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(277, 730);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(249, 59);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(532, 730);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(249, 59);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.btnSil.Font = new System.Drawing.Font("Corbel", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(787, 730);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(249, 59);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(12, 96);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(130, 45);
            this.lblKontrol.TabIndex = 1;
            this.lblKontrol.Text = "label10";
            this.lblKontrol.Visible = false;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1068, 821);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Bilgi";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKontrol;
    }
}