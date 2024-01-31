﻿using System;
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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJ0REGB\\SQLEXPRESS01;Initial Catalog=pansiyonuygulamasi;Integrated Security=True");
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hesapla butonuna tıklandığında maaşlar hesaplanır.
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblPersonelMaas.Text = (personel * 7000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - Convert.ToInt32(LblPersonelMaas.Text) - Convert.ToInt32(LblAlinanUrunler1.Text) - Convert.ToInt32(LblAlinanUrunler2.Text) - Convert.ToInt32(LblAlinanUrunler3.Text) - Convert.ToInt32(LblFaturalar1.Text) - Convert.ToInt32(LblFaturalar2.Text) - Convert.ToInt32(LblFaturalar3.Text);
            LblSonuc.Text = sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {// Kasadaki toplam tutar
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();
            //Gıdalar

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
              LblAlinanUrunler1.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();

            //İçecekler

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

            //Atıştırmalıklar

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["toplam3"].ToString();

            }
            baglanti.Close();

            //Elektrik

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam4"].ToString();

            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam5"].ToString();

            }
            baglanti.Close();

            //Internet

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam6"].ToString();

            }
            baglanti.Close();

        }

        private void LblKasaToplam_Click(object sender, EventArgs e)
        {

        }
    }
}
