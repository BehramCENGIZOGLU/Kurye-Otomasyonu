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
    public partial class FrmPaket : Form
    {
        public FrmPaket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-H8DO9QCK;Initial Catalog=Kurye;Integrated Security=True");

        private void FrmPaket_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kuryeDataSet5.Tbl_Paket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PaketTableAdapter3.Fill(this.kuryeDataSet5.Tbl_Paket);
            // TODO: Bu kod satırı 'kuryeDataSet3.Tbl_Paket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PaketTableAdapter2.Fill(this.kuryeDataSet3.Tbl_Paket);
            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PaketTableAdapter3.Fill(this.kuryeDataSet5.Tbl_Paket);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutKaydet1 = new SqlCommand("insert into Tbl_Paket(PaketTürü,PaketBoyutu,PaketTeslimatyeri,PaketAğırlığı,PaketKırılabilir) values (@s1,@s2,@s3,@s4,@s5)", baglanti1);
            komutKaydet1.Parameters.AddWithValue("@s1", txtPaketTürü.Text);
            komutKaydet1.Parameters.AddWithValue("@s2", txtPaketBoyutu.Text);
            komutKaydet1.Parameters.AddWithValue("@s3", txtPaketTeslimatyeri.Text);
            komutKaydet1.Parameters.AddWithValue("@s4", txtPaketAğırlığı.Text);
            komutKaydet1.Parameters.AddWithValue("@s5", label6.Text);
            komutKaydet1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Paket başarılı bir şekilde kaydedilmiştir");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutGüncelle1 = new SqlCommand("update Tbl_Paket set PaketTürü=@d1,PaketBoyutu=@d2,PaketTeslimatyeri=@d3,PaketAğırlığı=@d4,PaketKırılabilir=@d5 where Paketİd=@d6", baglanti1);
            komutGüncelle1.Parameters.AddWithValue("@d1", txtPaketTürü.Text);
            komutGüncelle1.Parameters.AddWithValue("@d2", txtPaketBoyutu.Text);
            komutGüncelle1.Parameters.AddWithValue("@d3", txtPaketTeslimatyeri.Text);
            komutGüncelle1.Parameters.AddWithValue("@d4",txtPaketAğırlığı.Text);
            komutGüncelle1.Parameters.AddWithValue("@d5", label6.Text);
            komutGüncelle1.Parameters.AddWithValue("@d6", txtPaketİd.Text);
            komutGüncelle1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Paket başarılı bir şekilde güncellenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutSil1 = new SqlCommand("delete from Tbl_Paket where Paketİd=@c1", baglanti1);
            komutSil1.Parameters.AddWithValue("@c1", txtPaketİd.Text);
            komutSil1.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Paket başarılı bir şekilde silinmiştir");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label6.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                label6.Text = "false";
            }
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            if(label6.Text=="True")
            {
                radioButton1.Checked = true;
            }
            if(label6.Text=="False")
            {
                radioButton2.Checked = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmKurye frmK = new FrmKurye();
            frmK.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen1 = dataGridView1.SelectedCells[0].RowIndex;
            txtPaketİd.Text = dataGridView1.Rows[secilen1].Cells[0].Value.ToString();
            txtPaketTürü.Text = dataGridView1.Rows[secilen1].Cells[1].Value.ToString();
            txtPaketBoyutu.Text = dataGridView1.Rows[secilen1].Cells[2].Value.ToString();
            txtPaketTeslimatyeri.Text = dataGridView1.Rows[secilen1].Cells[3].Value.ToString();
            txtPaketAğırlığı.Text = dataGridView1.Rows[secilen1].Cells[4].Value.ToString();
            label6.Text = dataGridView1.Rows[secilen1].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKurye_Paket frmkp = new FrmKurye_Paket();
            frmkp.Show();
            this.Hide();
        }
    }
}
