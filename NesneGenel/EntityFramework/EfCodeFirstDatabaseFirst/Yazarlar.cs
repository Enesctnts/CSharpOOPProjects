namespace EfCodeFirstDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yazarlar")]
    public partial class Yazarlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yazarlar()
        {
            Kitaplar = new HashSet<Kitaplar>();
        }

        [Key]
        public int YazarID { get; set; }

        [StringLength(20)]
        public string YazarAdi { get; set; }

        [StringLength(20)]
        public string YazarSoyad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitaplar> Kitaplar { get; set; }
    }
}
