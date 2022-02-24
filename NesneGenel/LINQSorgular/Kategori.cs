using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSorgular
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public override string ToString()
        {
            return $" KategoriID: {KategoriID} KategoriAdi: {KategoriAdi} ";
        }
    }
}
