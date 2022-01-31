using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3.Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Veysel";
            ogretmen1.Soyad = "PERU";


            Ogrenci ogrenci1 = new Ogrenci("Enes",  "Çetintaş", "1996", ogretmen1, 10161805000);
            Ogrenci ogrenci2 = new Ogrenci("Mehmet",  "Kılıç",  "1997", ogretmen1, 99999805000);
            Ogrenci ogrenci3 = new Ogrenci("Mikail", "Çetintaş","1998", ogretmen1, 88888805000);
            Ogrenci ogrenci4 = new Ogrenci("Samet", "Gergin", "1995", ogretmen1, 77777805000);
            ogretmen1.Ogrenciler.Add(ogrenci1);
            ogretmen1.Ogrenciler.Add(ogrenci2);
            ogretmen1.Ogrenciler.Add(ogrenci3);
            ogretmen1.Ogrenciler.Add(ogrenci4);


            //ogrenci1.BilgiYaz(Bilgiler);
            ogretmen1.OgrenciListele(Bilgiler);

            Ogretmen ogretmen2 = new Ogretmen();

            ogretmen2.Ad = "Görkem";
            ogretmen2.Soyad = "Kılıç";

           //ogrenci4.SinifOgretmeniDegis(ogretmen2);
           //ogrenci3.SinifOgretmeniDegis(ogretmen2);
          
            Ogrenci ogrenci5 = new Ogrenci("Uğur",    "Önsal", "1998", ogretmen2, 66666805000);
            Ogrenci ogrenci6 = new Ogrenci("Batuhan", "Uruğ",  "1997", ogretmen2, 55555805000);
            ogretmen2.Ogrenciler.Add(ogrenci5);
            ogretmen2.Ogrenciler.Add(ogrenci6);
            ogretmen2.OgrenciListele(Bilgiler);




        }
    }
}
