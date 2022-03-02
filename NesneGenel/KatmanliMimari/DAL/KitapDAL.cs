using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KitapDAL : ICRUD<Kitap>
    {
        public void Ekle(Kitap entity)
        {
            SqlConnection conn = new SqlConnection(KitapDB.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Kitaplar(KitapAdi,KategoriID,YazarID) Values(@ad,@kID,@yID)", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", entity.KitapAdi);
            cmd.Parameters.AddWithValue("@kID", entity.KategoriID);
            cmd.Parameters.AddWithValue("@yID", entity.YazarID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Kitap> Liste()
        {
            SqlConnection conn = new SqlConnection(KitapDB.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select KitapID,KitapAdi,KategoriID,YazarID from Kitaplar", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Kitap> kitaplar = new List<Kitap>();

            while (dr.Read())
            {
                Kitap kitap = new Kitap()
                {
                    KitapID = Convert.ToInt32(dr[0]),
                    KitapAdi = dr[1].ToString(),
                    KategoriID = dr.IsDBNull(2) ? 0 : Convert.ToInt32(dr[2]),
                    YazarID = dr.IsDBNull(3) ? 0 : Convert.ToInt32(dr[3])
                };
                kitaplar.Add(kitap);
            }
            
            conn.Close();
            return kitaplar;
        }
    }
}
