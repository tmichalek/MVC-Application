namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wysylka")]
    public partial class Wysylka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wysylka()
        {
            Kosztorys = new HashSet<Kosztorys>();
        }

        public int WysylkaId { get; set; }

        public double Cena { get; set; }

        public string Opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kosztorys> Kosztorys { get; set; }
    }
}
