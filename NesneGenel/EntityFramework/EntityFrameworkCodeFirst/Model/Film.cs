using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Model
{
    [Table("Filmler")] //Veritabanındaki tablonun ismi otomatik olarak "s" takısı alarak oluşur. biz FİLMLER şeklinde oluşturmak için "atribute" kullanarak yan taraftaki gibi yapılır
    public class Film
    {
        public int FilmID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string FilmAdi { get; set; }
        public int KategoriID { get; set; }
        public int YonetmenID { get; set; }
        public short Sure { get; set; }

        public virtual Kategori Kategori { get; set; } //Virtual varsa Lazy Loading ' tir.  Virtual yazarsak bütün verileri getircek 
        public Yonetmen Yonetmen { get; set; }//Burada virtual kullanmadık. Sorguda INCLUDE komutuyla getircez.İki yöntemide görmek için bunu yaptık.bu yönteme Eager loading deniyor. Eğer bir sorguda INCLUDE varsa Eager loading dir. 

        public virtual ICollection<FilmOyuncu> Oyuncular { get; set; }

    }
}
