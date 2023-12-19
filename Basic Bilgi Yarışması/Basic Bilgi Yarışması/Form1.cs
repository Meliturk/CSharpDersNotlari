using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlıs = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label8.Text = btnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                dogruLbl.Text = dogru.ToString();
                yesilPb.Visible = true;
            }
            else
            {
                yanlıs++;
                yanlısLbl.Text = yanlıs.ToString();
                kirmiziPb.Visible = true;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label8.Text = btnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                dogruLbl.Text = dogru.ToString();
                yesilPb.Visible = true;
            }
            else
            {
                yanlıs++;
                yanlısLbl.Text = yanlıs.ToString();
                kirmiziPb.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonraki.Enabled = true;

            label8.Text = btnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                dogruLbl.Text = dogru.ToString();
                yesilPb.Visible = true;
            }
            else
            {
                yanlıs++;
                yanlısLbl.Text = yanlıs.ToString();
                kirmiziPb.Visible = true;

            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            label8.Text = btnA.Text;
            if(label7.Text== label8.Text)
            {
                dogru++;
                dogruLbl.Text = dogru.ToString();
                yesilPb.Visible = true;
            }
            else
            {
                yanlıs++;
                yanlısLbl.Text = yanlıs.ToString();
                kirmiziPb.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;


            soruNo++;
            soruNoLbl.Text = soruNo.ToString();
            btnSonraki.Text = "Sonraki Soru";
            yesilPb.Visible = false;
            kirmiziPb.Visible= false;

            if(soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyer kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label7.Text = "1923";
                
            }
            if(soruNo == 2)
            {
                richTextBox1.Text = "Dokuzunncu Hariciye Koğuşu'nu hangi yazarımız yazmıştır?";
                btnA.Text = "Peyami Safa";
                btnB.Text = "Refik Halit Karay";
                btnC.Text = "Tarık Buğra";
                btnD.Text = "Yakup Kadri Karaosmanoğlu";
                label7.Text = "Peyami Safa";

            }
            if(soruNo == 3)
            {
                richTextBox1.Text = "Kahramanmaraş Hangi bölgemizdedir?";
                btnA.Text = "Ege";
                btnB.Text = "İç Anadolu";
                btnC.Text = "Akdeniz";
                btnD.Text = "Güneydoğu Anadolu";
                label7.Text = "Akdeniz";
            }
            if(soruNo == 4)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Atilla İlhan";
                btnC.Text = "Cemal Süreyya";
                btnD.Text = "Reşat Nuri Güntekin";
                label7.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";


            }
            if(soruNo==5)
            {

                btnA.Enabled= false;
                btnB.Enabled= false;
                btnC.Enabled= false;
                btnD.Enabled= false;
                btnSonraki.Enabled= false;
                MessageBox.Show("Doğru: " + dogru + "\nYanlış: " + yanlıs);
            }
            
        }
    }
}
