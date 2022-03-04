using EntityFrameworkCodeFirst.DAL;
using EntityFrameworkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmDB db = new FilmDB();
            dataGridView1.DataSource = db.Filmler.ToList();
        }

        private void btnLazy_Click(object sender, EventArgs e)
        {
            FilmDB db = new FilmDB();
            //var liste = from f in db.Filmler
            //            select new
            //            {
            //                f.FilmID,
            //                Ad = f.FilmAdi,
            //                f.Kategori.KategoriAdi,
            //                f.Yonetmen.YonetmenAdi
            //            };
            var liste = db.Filmler.ToList();
            dataGridView1.DataSource = liste.ToList();
        }

        private void btnEager_Click(object sender, EventArgs e)
        {
            //Model de navigation prop. önünde "virtual" olup olmamasına göre çalışması değişir..
            FilmDB db = new FilmDB();
            var liste = db.Filmler.Include("Kategori").Include("Yonetmen").ToList();
            dataGridView1.DataSource = liste.ToList();
        }
        FilmDB db = new FilmDB();
        private void btnKatogoriEkle_Click(object sender, EventArgs e)
        {
            db.Kategoriler.Add(new Kategori { KategoriAdi = "Eğlence" });
            db.SaveChanges();
        }

        private void btnFilmAra_Click(object sender, EventArgs e)
        {
            var film = db.Filmler.Find(1);
            var film2 = db.Filmler.Where(f => f.FilmID == 1).SingleOrDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kategori = db.Kategoriler.Find(4);
            db.Kategoriler.Remove(kategori);
            MessageBox.Show("Silindi");
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategori kat = db.Kategoriler.Find(4);
            db.Entry<Kategori>(kat).State=EntityState.Modified;
            kat.KategoriAdi = "Eglence";
            db.SaveChanges();


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string strAra = textBox1.Text;

            var result = db.Filmler.Where(f => f.FilmAdi.Contains(strAra));

            dataGridView1.DataSource = result.ToList();
        }
    }
}
