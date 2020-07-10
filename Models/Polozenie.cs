namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Polozenie")]
    public partial class Polozenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polozenie()
        {
            X_Y = new HashSet<X_Y>();
        }

        public int PolozenieId { get; set; }

        public int PracaId { get; set; }

        public virtual Praca Praca { get; set; }

        public virtual Praca Praca1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<X_Y> X_Y { get; set; }
    }
}
