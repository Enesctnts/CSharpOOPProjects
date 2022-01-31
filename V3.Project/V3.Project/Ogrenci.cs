using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace V3.Project
{
    /*
     Ogrenci sınıfındaki özellik ve metotları tanımlayınız
    Properties : TcNo , OkulNo,Ad,Soyad,SinifOgretmeni
    Metgods:SinifOgretmeniDeğistir(string ogretmen)
    Methods: BilgiYaz(), ogrencinin tüm bilgilerini ekrana yazılsın
    Methods: Parametreli yapıcı metot ekleyin.
    */
     
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OkulNo { get; set; }
        //public string SinifOgretmeni { get; set; }
        public Ogretmen SinifOgretmeni { get; set; }
        public long TcNo { get; set; }

        public Ogrenci(string _Ad, string _Soyad, string _OkulNo, Ogretmen _SinifOgretmeni, long _TcNo)
        {
            Ad = _Ad;
            Soyad = _Soyad;
            OkulNo = _OkulNo;
            SinifOgretmeni = _SinifOgretmeni;
            TcNo = _TcNo;
        }

        public void SinifOgretmeniDegis(Ogretmen _SinifOgretmeni)
        {
            SinifOgretmeni = _SinifOgretmeni;
        }
        public void BilgiYaz(ListBox listBox1)
        {
            MessageBox.Show("Ad: " + Ad + "\nSoyad: " + Soyad + "\nTc No: " + TcNo.ToString()
                           + "\nOkulNo: " + OkulNo + "\nSinif Ögretmeni Ad Soyad: " + SinifOgretmeni.Ad + " " + SinifOgretmeni.Soyad);
            listBox1.Items.Add("Ad: " + Ad);
            listBox1.Items.Add("Soyad: " + Soyad);
            listBox1.Items.Add("Tc No: " + TcNo.ToString());
            listBox1.Items.Add("OkulNo: " + OkulNo);
            listBox1.Items.Add("Sinif Ögretmeni Ad: " + SinifOgretmeni.Ad + "Sinif Ögretmeni Soyad: " + SinifOgretmeni.Soyad);
        } 
    }

}
