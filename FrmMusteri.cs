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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Firma;Integrated Security=True;");

        private void Listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Musteri",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {

            Listele();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtBakiye.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Musteri where Musteri_Ad like '" + txtBul.Text + "%'",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void txtBul_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Musteri where Musteri_Ad like '" + txtBul.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
