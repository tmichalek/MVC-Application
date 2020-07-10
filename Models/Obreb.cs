namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Obreb")]
    public partial class Obreb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obreb()
        {
            Praca = new HashSet<Praca>();
        }

        public int ObrebId { get; set; }

        public int GminaId { get; set; }

        public string Nr_teryt { get; set; }

        public string NazwaObreb { get; set; }

        public virtual Gmina Gmina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Praca> Praca { get; set; }
    }
}
