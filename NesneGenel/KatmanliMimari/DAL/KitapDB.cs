using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KitapDB
    {
        public static string ConnectionString { get; set; }
        public KitapDAL Kitaplar { get; set; }
        public KategoriDAL Kategoriler { get; set; }
        


        public KitapDB()
        {
            Kitaplar = new KitapDAL();
            Kategoriler = new KategoriDAL();
            ConnectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

    }
}
