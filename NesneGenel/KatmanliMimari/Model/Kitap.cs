using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public int KategoriID    { get; set; }
        public int YazarID { get; set; }
    }
}
