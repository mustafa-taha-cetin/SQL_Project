using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_SQL
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Firma;Integrated Security=True;");



        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urun_Id,Urun_Ad,Urun_Marka,Kategori_Ad,Urun_Alis,Urun_Fiyat,Urun_Stok,Urun_Durum from tbl_Urunler inner join Tbl_Kategori on Tbl_Urunler.Urun_Kategori = Tbl_Kategori.Kategori_Id", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Temizle()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtDurum.Text = "";
            txtFiyat.Text = "";
            cmbKategori.Text = "";
            txtMarka.Text = "";
            txtStok.Text = "";
        }


        private void FrmUrunler_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urun_Id,Urun_Ad,Urun_Marka,Kategori_Ad,Urun_Alis,Urun_Fiyat,Urun_Stok,Urun_Durum from tbl_Urunler inner join Tbl_Kategori on Tbl_Urunler.Urun_Kategori = Tbl_Kategori.Kategori_Id", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut = new SqlCommand("Select Kategori_Ad from tbl_Kategori", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKategori.Items.Add(dr[0].ToString());
            }

            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            Temizle();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtStok.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urun_Id,Urun_Ad,Urun_Marka,Kategori_Ad,Urun_Alis,Urun_Fiyat,Urun_Stok,Urun_Durum from tbl_Urunler inner join Tbl_Kategori on Tbl_Urunler.Urun_Kategori = Tbl_Kategori.Kategori_Id", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtMarka.Text == "" || txtDurum.Text == "" || txtFiyat.Text == "" || txtStok.Text == "" || cmbKategori.Text == "")
            {
                MessageBox.Show("Yeni ürün eklemek için tüm değerleri doldurunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Tbl_Urunler (Urun_ad, Urun_Marka, Urun_Kategori, Urun_Fiyat, Urun_Stok, Urun_Durum) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMarka.Text);
                komut.Parameters.AddWithValue("@p3", lblKontrol.Text);
                komut.Parameters.AddWithValue("@p4", txtFiyat.Text);
                komut.Parameters.AddWithValue("@p5", txtStok.Text);
                komut.Parameters.AddWithValue("@p6", txtDurum.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Yeni ürün eklendi, Ürün adı: " + txtAd.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();

                baglanti.Close();

            }

            Temizle();



        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select Kategori_Id from Tbl_Kategori where Kategori_Ad = @k", baglanti);
            
            komut.Parameters.AddWithValue("@k",cmbKategori.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblKontrol.Text = dr[0].ToString();
            }

            baglanti.Close();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünün üstüne tıklayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglanti.Open();

                SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Urun_Ad = @p1, Urun_Marka = @p2,Urun_Kategori = @p3, Urun_Fiyat = @p4, Urun_Stok = @p5, Urun_Durum = @p6 where Urun_Id = @p", baglanti);

                komut.Parameters.AddWithValue("@p", txtId.Text);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMarka.Text);
                komut.Parameters.AddWithValue("@p3", lblKontrol.Text);
                komut.Parameters.AddWithValue("@p4", txtFiyat.Text);
                komut.Parameters.AddWithValue("@p5", txtStok.Text);
                komut.Parameters.AddWithValue("@p6", txtDurum.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Listele();

                baglanti.Close() ;


            }



        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ürünün üzerine tıklayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {

                baglanti.Open();

                SqlCommand komut = new SqlCommand("Delete from tbl_urunler where Urun_Id = @p",baglanti);
                komut.Parameters.AddWithValue("@p", txtId.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt silindi silinen kayıt: " + txtAd.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Listele();

                baglanti.Close();

            }

            Temizle();

        }
    }
}
