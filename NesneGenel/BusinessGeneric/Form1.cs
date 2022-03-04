using BusinessGeneric.BLL;
using BusinessGeneric.DAL;
using BusinessGeneric.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFilmler_Click(object sender, EventArgs e)
        {
            GenericFilmDB db = new GenericFilmDB();
            GenericBLL<Film> film = new GenericBLL<Film>(db);

            dataGridView1.DataSource = film.Listele();

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            GenericFilmDB db = new GenericFilmDB();
            GenericBLL<Kategori> kat = new GenericBLL<Kategori>(db);
            Kategori kategori = new Kategori(){ KategoriAdi = "Uzay" };
            kat.Ekle(kategori);

            dataGridView1.DataSource = kat.Listele();

        }

        private void btnYonetmenler_Click(object sender, EventArgs e)
        {
            GenericFilmDB db = new GenericFilmDB();
            GenericBLL<Yonetmen> yon = new GenericBLL<Yonetmen>(db);
            Yonetmen yonetmen = new Yonetmen() { YonetmenAdi = "Tarantino" };
            yon.Ekle(yonetmen);

            dataGridView1.DataSource = yon.Listele();
        }
    }
}
