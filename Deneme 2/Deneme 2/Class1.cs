using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_2
{
    internal class Personel
    {
        public Personel(string gAd, int gMesai, string gUnvan)
        {
            this.Ad = gAd;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;

        }

        string ad;
        public string Ad
        { get => ad;
            set => ad = value;
        }
        int mesai;
        public int Mesai
        {
            get { return mesai; }
            set => mesai = value;
        }
        string unvan;
        public string Unvan
        { get => unvan;
            set => unvan = value;
        }
        

        
        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }

        
        public void ucretHesapla(int ekUcret)
        {
            ekUcret = 1000;
            int odenecek = this.Mesai * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());
        }



     }
}
