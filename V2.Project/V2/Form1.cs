using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            araba1.Id = 2;
            araba1.Marka = "Mazda";
            araba1.Model = "2020";
            araba1.BilgiYaz();

            Araba arabaNesnesi = new Araba(1,"BMW","2022");
            arabaNesnesi.BilgiYaz();
            
            
        }
    }
}
