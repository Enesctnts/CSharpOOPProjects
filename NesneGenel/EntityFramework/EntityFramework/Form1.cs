using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapDBEntities db = new KitapDBEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kitaplar.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            db.Kitaplar.Add(new Kitaplar
            {
                KitapAdi = "Harry Potter",
                KategoriID = 2,YazarID=2
            });
            db.SaveChanges();
        }
        public void Mesaj(string str)
        {
           MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Database.Log = Mesaj;
            dataGridView1.DataSource = db.Kitaplar.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var result = from k in db.Kitaplar
            //             join kat in db.Kategoriler
            //             on k.KategoriID equals kat.KategoriID
            //             join yaz in db.Yazarlar
            //             on k.YazarID equals yaz.YazarID
            //             select new 
            //             {
            //                 k.KitapID,
            //                 k.KitapAdi,
            //                 yaz.YazarAdi,
            //                 kat.KategoriAdi
            //             };
            //dataGridView1.DataSource = result.ToList();

            var result2 = from k in db.Kitaplar
                          select new
                          {
                              k.KitapID,
                              k.KitapAdi,
                              k.Kategoriler.KategoriAdi,
                              k.Yazarlar.YazarAdi
                          };
            dataGridView1.DataSource = result2.ToList();

        }
    }
}
