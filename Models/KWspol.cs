namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KWspol")]
    public partial class KWspol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KWspol()
        {
            Kosztorys = new HashSet<Kosztorys>();
        }

        [Key]
        public int KId { get; set; }

        public double K { get; set; }

        public string Opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kosztorys> Kosztorys { get; set; }
    }
}
