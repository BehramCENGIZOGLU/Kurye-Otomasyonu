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
    public partial class FrmKuryePaket1 : Form
    {
        public FrmKuryePaket1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-H8DO9QCK;Initial Catalog=Kurye;Integrated Security=True");
        private void FrmKuryePaket1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kuryeDataSet18.Tbl_KuryePaket1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KuryePaket1TableAdapter2.Fill(this.kuryeDataSet18.Tbl_KuryePaket1);
            // TODO: Bu kod satırı 'kuryeDataSet17.Tbl_Paket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PaketTableAdapter1.Fill(this.kuryeDataSet17.Tbl_Paket);
            // TODO: Bu kod satırı 'kuryeDataSet16.Tbl_Kurye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KuryeTableAdapter1.Fill(this.kuryeDataSet16.Tbl_Kurye);

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
            int secilen3 = dataGridView1.SelectedCells[0].RowIndex;
            txtPaketTürü.Text = dataGridView2.Rows[secilen3].Cells[0].Value.ToString();
            txtPaketTeslimatyeri.Text = dataGridView2.Rows[secilen3].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komutKaydet2 = new SqlCommand("insert into Tbl_KuryePaket(KuryeAd,KuryeSoyad,KuryeSehir,PaketTürü,PaketTeslimatyeri) values (@w1,@w2,@w3,@w4,@w5)", baglanti2);
            komutKaydet2.Parameters.AddWithValue("@w1", txtKuryeAd.Text);
            komutKaydet2.Parameters.AddWithValue("@w2", txtKuryeSoyad.Text);
            komutKaydet2.Parameters.AddWithValue("@w3", txtKuryeSehir.Text);
            komutKaydet2.Parameters.AddWithValue("@w4", txtPaketTürü.Text);
            komutKaydet2.Parameters.AddWithValue("@w5", txtPaketTeslimatyeri.Text);
            komutKaydet2.ExecuteNonQuery();
            baglanti2.Close();
            MessageBox.Show("Teslimat başarılı bir şekilde gönderilmiştir");
        }
    }
}
