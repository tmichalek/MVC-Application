namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AjWspol")]
    public partial class AjWspol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AjWspol()
        {
            Kosztorys = new HashSet<Kosztorys>();
        }

        [Key]
        public int AjId { get; set; }

        public double Aj { get; set; }

        public double NrTabeli { get; set; }

        public string Opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kosztorys> Kosztorys { get; set; }
    }
}
