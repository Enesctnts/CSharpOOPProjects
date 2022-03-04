using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGeneric.Model
{
    [Table("Filmler")]
    public class Film:IEntity
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public int KategoriID { get; set; }
        public int YonetmenID { get; set; }
        public short Sure { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual Yonetmen Yonetmen { get; set; }

        
    }
}
