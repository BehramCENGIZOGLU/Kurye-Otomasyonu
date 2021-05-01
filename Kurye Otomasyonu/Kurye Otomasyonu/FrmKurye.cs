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
    public partial class FrmKurye : Form
    {
        public FrmKurye()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-H8DO9QCK;Initial Catalog=Kurye;Integrated Security=True");

        private void kuryeDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kuryeDataSet4.Tbl_Kurye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KuryeTableAdapter1.Fill(this.kuryeDataSet4.Tbl_Kurye);


        }

        private void btnListele_Click (object sender, EventArgs e)
        {
            this.tbl_KuryeTableAdapter1.Fill(this.kuryeDataSet4.Tbl_Kurye);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Kurye(KuryeAd,KuryeSoyad,KuryeSehir,KuryeMaas,KuryeDurum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutKaydet.Parameters.AddWithValue("@p1", txtKuryeAd.Text);
            komutKaydet.Parameters.AddWithValue("@p2", txtKuryeSoyad.Text);
            komutKaydet.Parameters.AddWithValue("@p3", cmbKuryeSehir.Text);
            komutKaydet.Parameters.AddWithValue("@p4", txtKuryeMaas.Text);
            komutKaydet.Parameters.AddWithValue("@p5", label7.Text);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı bir şekilde kaydedilmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Kurye where Kuryeİd=@k1", baglanti);
            komutSil.Parameters.AddWithValue("@k1", txtKuryeİd.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı bir şekilde silinmiştir");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label7.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton2.Checked==true)
            {
                label7.Text = "false";
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            if (label7.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label7.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGüncelle = new SqlCommand("Update Tbl_Kurye set KuryeAd=@a1,KuryeSoyad=@a2,KuryeSehir=@a3,KuryeMaas=@a4,KuryeDurum=@a5 where Kuryeİd=@a6", baglanti);
            komutGüncelle.Parameters.AddWithValue("@a1", txtKuryeAd.Text);
            komutGüncelle.Parameters.AddWithValue("@a2", txtKuryeSoyad.Text);
            komutGüncelle.Parameters.AddWithValue("@a3", cmbKuryeSehir.Text);
            komutGüncelle.Parameters.AddWithValue("@a4", txtKuryeMaas.Text);
            komutGüncelle.Parameters.AddWithValue("@a5", label7.Text);
            komutGüncelle.Parameters.AddWithValue("@a6", txtKuryeİd.Text);
            komutGüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı bir şekilde güncellenmiştir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPaket frmP = new FrmPaket();
            frmP.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKuryeİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKuryeAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKuryeSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbKuryeSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKuryeMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
