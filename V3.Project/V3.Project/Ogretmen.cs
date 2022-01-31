using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace V3.Project
{
    class Ogretmen
    {
        /*
         Id , Ad Soyad , Ogrenciler(List of ogrenci) 
        Bilgi Yaz(Ad Soyad)
        Ogrenci Listele
        */
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public Ogretmen()
        {
            this.Ogrenciler = new List<Ogrenci>();
        }
        
        public void OgrenciListele(ListBox listBox1)
        {
            MessageBox.Show("*******" + Ad + " " + Soyad + " öğretmenin öğrencileri");
            foreach (var item in this.Ogrenciler)
            {
                MessageBox.Show("Ad: " + item.Ad + "\nSoyad: " + item.Soyad + "\nTc No: " + item.TcNo.ToString() + "\nOkulNo: " + item.OkulNo );
                listBox1.Items.Add("Ad: " + item.Ad);
                listBox1.Items.Add("Soyad: " + item.Soyad);
                listBox1.Items.Add("Tc No: " + item.TcNo.ToString());
                listBox1.Items.Add("OkulNo: " + item.OkulNo);
                listBox1.Items.Add("\n");

            }
            MessageBox.Show("*****************************");
        }


    }
}
