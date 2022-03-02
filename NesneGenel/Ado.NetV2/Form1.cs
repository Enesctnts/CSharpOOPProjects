using Ado.NetV2.DAL;
using Ado.NetV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ado.NetV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapDAL db = new KitapDAL();
            dataGridView1.DataSource = db.KitapListeVM();
            cmbYazar.DataSource = db.Yazarlar();
            cmbYazar.DisplayMember = "YazarADSOYAD";
            cmbYazar.ValueMember = "YazarId";
            cmbKategori.DataSource = db.Kategoriler();
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "KategoriId";
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapDAL db = new KitapDAL();
            Kitap kitap = new Kitap();
            kitap.KitapAd = txtKitapAdi.Text;
            kitap.KategoriID = ((Kategori)cmbKategori.SelectedItem).KategoriID;
            kitap.YazarID = ((Yazar)cmbYazar.SelectedItem).YazarID;
            db.KitapEkle(kitap);
            dataGridView1.DataSource = db.KitapListeVM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Burası Formda ? butonuna bastığımız zaman bilgileri textbox'a getirmek için yazdıgımız kodlar.
            KitapDAL db = new KitapDAL();

            if (txtKitapID.Text!="")
            {
            
            Kitap kitap= db.KitapBul(int.Parse(txtKitapID.Text));

            if (kitap.KitapID>0)
            {
                ButonDurumlari(false);
                txtKitapAdi.Text = kitap.KitapAd;
                List<Kategori> katlist = ((List<Kategori>)cmbKategori.DataSource);
                int indis = -1;
                for (int i = 0; i < katlist.Count; i++)
                {
                    if (katlist[i].KategoriID==kitap.KategoriID)
                    {
                        indis = i;
                        break;
                    }
                }
                cmbKategori.SelectedIndex = indis;
                
                List<Yazar> yazlist = ((List<Yazar>)cmbYazar.DataSource);
                indis = -1;
                for (int i = 0; i < yazlist.Count; i++)
                {
                    if (yazlist[i].YazarID == kitap.YazarID)
                    {
                        indis = i;
                        break;
                    }
                }
                cmbYazar.SelectedIndex = indis;


                }
            else
            {
                MessageBox.Show("Aradığınız kayıt bulunamadı...");
            }

            }
            else
            {
                MessageBox.Show("Kitap ID girmelisiniz.");
            }
        }

        private void ButonDurumlari(bool durum)
        {
            btnKitapEkle.Enabled = durum;
            groupBox1.Enabled = !durum;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            ButonDurumlari(true);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KitapDAL db = new KitapDAL();

            Kitap kitap = new Kitap();
            kitap.KitapID = int.Parse(txtKitapID.Text);
            kitap.KitapAd = txtKitapAdi.Text;
            kitap.KategoriID = ((Kategori)cmbKategori.SelectedItem).KategoriID;
            kitap.YazarID = ((Yazar)cmbYazar.SelectedItem).YazarID;

            db.KitapGuncelle(kitap);
            ButonDurumlari(true);
            dataGridView1.DataSource = db.KitapListeVM();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            KitapDAL db = new KitapDAL();
            DialogResult dr=MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr==DialogResult.Yes)
            {
                db.KitapSil(int.Parse(txtKitapID.Text));
            }
            ButonDurumlari(true);
            dataGridView1.DataSource = db.KitapListeVM();
        }
    }
}
