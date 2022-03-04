using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Model
{
    public class FilmOyuncu
    {   
        [Key]
        public int FO_ID { get; set; }
        public int FilmID { get; set; }
        public int OyuncuID { get; set; }
        public string RolAdi { get; set; }

        public virtual Film Film { get; set; }
        public virtual Oyuncu Oyuncu { get; set; }
    }
}
