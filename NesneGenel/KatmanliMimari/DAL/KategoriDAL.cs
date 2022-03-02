using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KategoriDAL : ICRUD<Kategori>
    {
        public void Ekle(Kategori entity)
        {
            //SqlConnection conn = new SqlConnection(KitapDB.ConnectionString);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Insert Into Kategoriler(KategoriAdi,) Values(@ad,@kID,@yID)", conn);
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@ad", entity.KitapAdi);
            //cmd.Parameters.AddWithValue("@kID", entity.KategoriID);
            //cmd.Parameters.AddWithValue("@yID", entity.YazarID);
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

        public List<Kategori> Liste()
        {
            throw new NotImplementedException();
        }
    }
}
