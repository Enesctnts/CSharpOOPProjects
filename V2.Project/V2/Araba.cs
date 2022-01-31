using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace V2
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Araba()
        {
            MessageBox.Show("Parametresiz Yapıcı Metot Çalıştı");
        }
        public Araba(int _Id , string _Marka , string _Model)
        {
            MessageBox.Show("3 Parametreli Yapıcı Metot Çalıştı");
            Id = _Id;
            Marka = _Marka;
            Model = _Model;
        }

        public void BilgiYaz()
        {
            MessageBox.Show("Marka: " + this.Marka + "\n" + "Model: " + this.Model);
        }



    }
}
