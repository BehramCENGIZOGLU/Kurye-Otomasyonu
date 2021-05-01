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
    public partial class FrmKuryePaket : Form
    {
        public FrmKuryePaket()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-H8DO9QCK;Initial Catalog=Kurye;Integrated Security=True");
        private void FrmKuryePaket_Load(object sender, EventArgs e)
        {
           
            baglanti2.Open();
            SqlCommand komut3 = new SqlCommand();
            SqlDataReader oku;
            komut3.Connection = baglanti2;
            komut3.CommandText = "select * from Tbl_Kurye ";
            oku = komut3.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[1].ToString());
            }
            baglanti2.Close();

            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // SqlCommand komutKaydet2 = new SqlCommand("insert into Tbl_KuryePaket, baglanti2);
           // komutKaydet2.Parameters.AddWithValue("")
            //baglanti2.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut4 = new SqlCommand();
            SqlDataReader oku2;
            komut4.Connection = baglanti2;
            komut4.CommandText = "select * from Tbl_Kurye";
            oku2 = komut4.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2[2].ToString());
            }
            baglanti2.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut5 = new SqlCommand();
            SqlDataReader oku3;
            komut5.Connection = baglanti2;
            komut5.CommandText = "select * from Tbl_KuryePaket";
            oku3 = komut5.ExecuteReader();
            while (oku3.Read())
            {
                comboBox3.Items.Add(oku3[5].ToString());
            }
            baglanti2.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut6 = new SqlCommand();
            SqlDataReader oku4;
            komut6.Connection = baglanti2;
            komut6.CommandText = "select * from Tbl_KuryePaket";
            oku4 = komut6.ExecuteReader();
            while (oku4.Read())
            {
                comboBox4.Items.Add(oku4[4].ToString());
            }
            baglanti2.Close();
        }
    }
}
