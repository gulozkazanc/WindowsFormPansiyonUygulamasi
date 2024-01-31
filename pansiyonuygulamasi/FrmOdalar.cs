using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pansiyonuygulamasi
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJ0REGB\\SQLEXPRESS01;Initial Catalog=pansiyonuygulamasi;Integrated Security=True");
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //Odalarda kalan müşteri isimlerini yazar
            //Oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btn101.Text = oku1["Adı"].ToString() +" "+ oku1["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn101.Text != "101") Btn101.BackColor = Color.Red;// oda doluysa kırmızı göster
            //Oda102

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adı"].ToString() + " " + oku2["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn102.Text != "102") Btn102.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Btn103.Text = oku3["Adı"].ToString() + " " + oku3["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn103.Text != "103") Btn103.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda104

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adı"].ToString() + " " + oku4["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn104.Text != "104") Btn104.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda105

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku5["Adı"].ToString() + " " + oku5["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn105.Text != "105") Btn105.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda106

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adı"].ToString() + " " + oku6["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn106.Text != "106") Btn106.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda107

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Btn107.Text = oku7["Adı"].ToString() + " " + oku7["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn107.Text != "107") Btn107.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda108

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Btn108.Text = oku8["Adı"].ToString() + " " + oku8["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn108.Text != "108") Btn108.BackColor = Color.Red;// oda doluysa kırmızı göster

            //Oda109

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Btn109.Text = oku9["Adı"].ToString() + " " + oku9["Soyadı"].ToString();
            }
            baglanti.Close();
            if (Btn109.Text != "109") Btn109.BackColor = Color.Red;// oda doluysa kırmızı göster

        }
    }
}
