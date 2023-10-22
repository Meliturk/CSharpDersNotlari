namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = adTxt.Text;
            ogr1.Soyad = soyadTxt.Text;
            ogr1.Eposta = (ePostaTxt.Text);
            ogr1.Adres = adresTxt.Text;
            ogr1.Yas = Convert.ToInt32(yasTxt.Text);
            MessageBox.Show("Ad&Soyad = " + ogr1.Ad + " " + ogr1.Soyad +
               "\nE-Posta = " + ogr1.Eposta +
               "\nAdres = " + ogr1.Adres +
               "\nDoðum tarihi = " + ogr1.Yas);


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}