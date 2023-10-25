namespace Deneme_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel prs1 = new Personel(adTxt.Text, Convert.ToInt32(mesaiTxt.Text), unvanCb.Text);


            if (unvanCb.Text == "Ýþçi")
            {
                MessageBox.Show(prs1.ucretHesapla().ToString());
            }
            else
            {
                prs1.ucretHesapla(1000);
            }









            /*MessageBox.Show("Ad Soyad = " + prs1.Ad +
                "\nMesai Saati = " + prs1.Mesai +
                "\nUnvan = " + prs1.Unvan +
                "\nÜcret = ");
            */

        }
    }
}