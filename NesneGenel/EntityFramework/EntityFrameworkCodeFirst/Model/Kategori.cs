using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Model
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }


        public virtual ICollection<Film> Filmler { get; set; }//Navigation property. Navigation property ile foreng keyleri veriyoruz.

    }
}
