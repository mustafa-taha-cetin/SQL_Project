using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrunler fr = new FrmUrunler();
            fr.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteri fr2 = new FrmMusteri();
            fr2.Show();
        }
    }
}
