using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                tbxSayi1.Text = tbxSayi1.Text.Replace(".", ",");// Virgül yerine nokta yazarsak yapılan işlem kabul edilsin diye noktayı virgül olarak kabul edicek.
                tbxSayi2.Text = tbxSayi2.Text.Replace(".", ",");// Virgül yerine nokta yazarsak yapılan işlem kabul edilsin diye noktayı virgül olarak kabul edicek.
                double toplam = 0;
                toplam = (Convert.ToDouble(tbxSayi1.Text)) + (Convert.ToDouble(tbxSayi2.Text));
                tbxToplam.Text = toplam.ToString("#####.##");
                Islem.Items.Add(tbxSayi1.Text + "+" + tbxSayi2.Text + "=" + tbxToplam.Text);// yapılan işlemleri göstermek için listbox kullandık.

            }
            catch (Exception)
            {

                Console.WriteLine("Geçersiz double");
            }
            

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                double Carpma = 0;
                tbxSayi1.Text = tbxSayi1.Text.Replace(".", ",");// Virgül yerine nokta yazarsak yapılan işlem kabul edilsin diye noktayı virgül olarak kabul edicek.
                tbxSayi2.Text = tbxSayi2.Text.Replace(".", ",");// Virgül yerine nokta yazarsak yapılan işlem kabul edilsin diye noktayı virgül olarak kabul edicek.
                Carpma = (Convert.ToDouble(tbxSayi1.Text)) * (Convert.ToDouble(tbxSayi2.Text));
                tbxToplam.Text = Carpma.ToString("#####.##");
                Islem.Items.Add(tbxSayi1.Text + "*" + tbxSayi2.Text + "=" + tbxToplam.Text);// yapılan işlemleri göstermek için listbox kullandık.
            }
            catch (Exception)
            {

                Console.WriteLine("Geçersiz işlem");
            }
            

        }
    }
}
