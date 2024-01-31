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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJ0REGB\\SQLEXPRESS01;Initial Catalog=pansiyonuygulamasi;Integrated Security=True");

        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read()){
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
     
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //Listview üzerinde id kısmına çift tıklandığında
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text= listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text= listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text= listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text= listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text=listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text= listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text= listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;

        }

       

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+MskTxtTelefon.Text+"',Mail='"+TxtMail.Text+"',TC='"+TxtTc.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='"+ DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where MusteriId="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listView1.Items.Clear();
            verilerigoster();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("delete from MusteriEkle where MusteriId=" + id + "", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

            if (TxtOdaNo.Text=="101") {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear(); 
            TxtMail.Clear();
            TxtTc.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";


        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        //Data Source=DESKTOP-TJ0REGB\SQLEXPRESS01;Initial Catalog=pansiyonuygulamasi;Integrated Security=True
    }
}
