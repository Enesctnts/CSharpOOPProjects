using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Model
{
    [Table("Oyuncular")]
    public class Oyuncu
    {

        public int OyuncuID { get; set; }
        [Column(TypeName="varchar"),StringLength(50)]
        public string OyuncuAdi { get; set; }
        public DateTime DogumYili { get; set; } = DateTime.Now;
        public string Cinsiyet { get; set; }

        public virtual ICollection<FilmOyuncu> Filmler { get; set; }

    }
}
