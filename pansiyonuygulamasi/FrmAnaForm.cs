﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonuygulamasi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            Frmyenimusteri fr = new Frmyenimusteri();
            fr.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
            
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Uygulaması/2023-Bursa");
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void BtnGelirGiderFormu_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();

        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void BtnRadyoDinle_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();
        }

        private void BtnMusteriMesaj_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
