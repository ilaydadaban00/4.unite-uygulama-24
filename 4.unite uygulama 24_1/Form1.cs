using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulama_24_1
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> liste = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.DersNotu = txtDersNotu.Text;
            ogrenci.AdSoyad = txtAdSoyad.Text;
            ogrenci.numara = txtNumara.Text;
            liste.Add(ogrenci);
            bagla();

        }
        private void bagla()
        {
            dgw.DataSource = null;
            dgw.DataSource = liste;
        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgw_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dgw.CurrentRow.Cells[0].Value.ToString();
            txtDersNotu.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            txtNumara.Text = dgw.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
