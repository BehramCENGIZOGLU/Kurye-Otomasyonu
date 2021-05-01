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

namespace Kurye_Otomasyonu
{
    public partial class FrmKurye_Paket : Form
    {
        public FrmKurye_Paket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-H8DO9QCK;Initial Catalog=Kurye;Integrated Security=True");
        private void FrmKurye_Paket_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kuryeDataSet26.Tbl_KuryePaket1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KuryePaket1TableAdapter.Fill(this.kuryeDataSet26.Tbl_KuryePaket1);
            // TODO: Bu kod satırı 'kuryeDataSet25.Tbl_Paket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PaketTableAdapter.Fill(this.kuryeDataSet25.Tbl_Paket);
            // TODO: Bu kod satırı 'kuryeDataSet24.Tbl_Kurye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KuryeTableAdapter.Fill(this.kuryeDataSet24.Tbl_Kurye);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen2 = dataGridView1.SelectedCells[0].RowIndex;
            txtKuryeAd.Text = dataGridView1.Rows[secilen2].Cells[0].Value.ToString();
            txtKuryeSoyad.Text = dataGridView1.Rows[secilen2].Cells[1].Value.ToString();
            txtKuryeSehir.Text = dataGridView1.Rows[secilen2].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen3 = dataGridView2.SelectedCells[0].RowIndex;
            txtPaketTürü.Text = dataGridView2.Rows[secilen3].Cells[0].Value.ToString();
            txtPaketTeslimatYeri.Text = dataGridView2.Rows[secilen3].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komutTeslimEt = new SqlCommand("insert into Tbl_KuryePaket1 (KuryeAd,KuryeSoyad,KuryeSehri,PaketTürü,PaketTeslimatyeri) values (@w1,@w2,@w3,@w4,@w5)", baglanti2);
            komutTeslimEt.Parameters.AddWithValue("@w1", txtKuryeAd.Text);
            komutTeslimEt.Parameters.AddWithValue("@w2", txtKuryeSoyad.Text);
            komutTeslimEt.Parameters.AddWithValue("@w3", txtKuryeSehir.Text);
            komutTeslimEt.Parameters.AddWithValue("@w4", txtPaketTürü.Text);
            komutTeslimEt.Parameters.AddWithValue("@w5", txtPaketTeslimatYeri.Text);
            komutTeslimEt.ExecuteNonQuery();
            baglanti2.Close();
            MessageBox.Show("Paket teslimat için kuryeye yönlendirilmiştir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_KuryePaket1TableAdapter.Fill(this.kuryeDataSet26.Tbl_KuryePaket1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPaket frmp = new FrmPaket();
            frmp.Show();
            this.Hide();
        }
    }
}
