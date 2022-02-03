using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetForm
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-HNE43R2;Database=DB_Test;Integrated Security=True;");
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListUpdate();
        }




        private void DbConnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Bağlantı Başarısız : " + exception);
            }
        }

        private void DBDisconnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Bağlantı Kapatma Başarısız : " + exception);
            }
        }

        private void OgrenciListUpdate()
        {
            SqlDataAdapter adpOgrenci = new SqlDataAdapter
                ("Select ID, Concat(ad, ' ', Soyad) as [Ad Soyad], Tel as [Telefon], tc as[TC K.Nu.], ad, soyad" +
                " from tb_ogrenci ORDER By ad, soyad", baglanti);
            DataTable dtOgrenci = new DataTable();
            adpOgrenci.Fill(dtOgrenci);
            data_ogrenciler.DataSource = dtOgrenci;
            data_ogrenciler.Columns["ID"].Visible = false;
            data_ogrenciler.Columns["ad"].Visible = false;
            data_ogrenciler.Columns["soyad"].Visible = false;

            //silme combocox'ı doldurduk
            // öğrenci ad soyad gösterilecek.
            // Seçilen ogrencinin ıd tutacak

            cmbSilinecek.DataSource = dtOgrenci;
            cmbSilinecek.DisplayMember = "Ad Soyad";
            cmbSilinecek.ValueMember = "ID";

            //Düzenleme Sekmesi
            cmbGüncelle.DataSource = dtOgrenci;
            cmbGüncelle.DisplayMember = "Ad Soyad";
            cmbGüncelle.ValueMember = "ID";


        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekId = int.Parse(cmbSilinecek.SelectedValue.ToString());

            SqlCommand silCommand = new SqlCommand("Delete from tb_ogrenci where ID=@id;", baglanti);
            silCommand.Parameters.Clear();
            silCommand.Parameters.AddWithValue("@id", silinecekId);

            string adSoyad = GetOgrenciAd(silinecekId);
            DialogResult cevap = MessageBox.Show(adSoyad + $" Silmek istediğinizden emin misiniz?", "Silme Onayı",
            MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                DbConnect();
                int etkilenenSatirSayisi = silCommand.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Silme İşlemi Tamamlandi.");
                }
                else
                {
                    MessageBox.Show("Herhangi bir kayıt bulunamadı.");
                }
                DBDisconnect();
                OgrenciListUpdate();
            }

        }
        private string GetOgrenciAd(int id)
        {
            DbConnect();
            SqlCommand sorgu = new SqlCommand($"Select Concat(Ad, ' ', Soyad) as [adSoyad] From Tb_ogrenci where ID={id};", baglanti);
            

            SqlDataReader dr = sorgu.ExecuteReader();
            string adSoyad = "";
            while (dr.Read())
            {
                adSoyad = dr.GetString(0);

            }
            DBDisconnect();
            return adSoyad;


        }

        private void tbnEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand insertCommand = new SqlCommand("Sp_OgrenciEkle", baglanti);
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Parameters.AddWithValue("@ad", txtAd.Text);
            insertCommand.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            insertCommand.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            insertCommand.Parameters.AddWithValue("@tc", txtTc.Text);
            DbConnect();
            int sonId = Convert.ToInt32(insertCommand.ExecuteScalar());
            MessageBox.Show(sonId.ToString());
            DBDisconnect();

        }
    }
}
