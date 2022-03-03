using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Model
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public int KategoriID { get; set; }
        public int YonetmenID { get; set; }
        public short Sure { get; set; }




    }
}
