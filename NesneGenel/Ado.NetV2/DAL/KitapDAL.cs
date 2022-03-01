using Ado.NetV2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetV2.DAL
{
    public class KitapDAL
    {
        private string strConn;
        public KitapDAL()
        {
            strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

        public List<Kitap> KitapListe()
        {
            List<Kitap> kitaplar = new List<Kitap>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Kitaplar", conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Kitap kitap = new Kitap();
                    kitap.KitapID = Convert.ToInt32(dr[0]);
                    kitap.KitapAd = dr[1].ToString();
                    kitap.KategoriID = dr.IsDBNull(2) ? 0 : (int?)dr[2];
                    kitap.YazarID = dr.IsDBNull(3) ? 0: (int?)dr[3];
                    kitap.EklenmeTarihi = dr.IsDBNull(3) ? DateTime.Parse("1/1/2000") : DateTime.Parse(dr[4].ToString());
                    kitap.GoruntulemeSayisi = dr.IsDBNull(5) ? 0 : (int?)dr[5];
                    
                    kitaplar.Add(kitap);
                }

            }
            return kitaplar;
        }


        public List<KitapVM> KitapListeVM()
        {
            List<KitapVM> kitaplar = new List<KitapVM>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            
            using (SqlCommand cmd = new SqlCommand("Select * from Kategoriler kat INNER JOIN Kitaplar ktp on kat.KategoriID=ktp.KategoriID INNER JOIN Yazarlar yzr ON ktp.YazarID=yzr.YazarID ", conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    KitapVM kitap = new KitapVM();
                    
                    kitap.KitapId = Convert.ToInt32(dr["KitapID"]);
                    kitap.KitapAdi = dr["KitapAdi"].ToString();
                    kitap.KategoriAdi = dr["KategoriAdi"].ToString();
                    kitap.YazarAdi = dr["YazarAdi"].ToString();
                    
                    kitaplar.Add(kitap);
                }

            }
            return kitaplar;
        }
        public void KitapEkle(Kitap kitap)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert INTO Kitaplar VALUES (@ad,@katID,@yazarId,getdate(),0)";

            cmd.Parameters.AddWithValue("@ad", kitap.KitapAd);
            cmd.Parameters.AddWithValue("@katID", kitap.KategoriID);
            cmd.Parameters.AddWithValue("@yazarId", kitap.YazarID);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        public void KitapSil(int kitapID)
        {

        }

        public Kitap KitapGetir(int kitapID)
        {
            return new Kitap();
        }

        public List<Kategori> Kategoriler()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Kategoriler", conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Kategori kategori = new Kategori()
                    {
                        KategoriID = Convert.ToInt32(dr[0]),
                        KategoriAd = dr[1].ToString()
                    };

                    kategoriler.Add(kategori);
                }

            }
            return kategoriler;
        }

        public List<Yazar> Yazarlar()
        {
            List<Yazar> yazarlar = new List<Yazar>();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Yazarlar", conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Yazar yazar = new Yazar()
                    {
                        YazarID= Convert.ToInt32(dr[0]),
                        YazarAd= dr[1].ToString(),
                        YazarSoyad= dr[2].ToString()
                    };
                    
                    yazarlar.Add(yazar);
                }

            }
            return yazarlar;
        }

    }
}
