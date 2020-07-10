namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cennik")]
    public partial class Cennik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cennik()
        {
            Kosztorys = new HashSet<Kosztorys>();
        }

        public int CennikId { get; set; }

        public short NrCennika { get; set; }

        public double Pozycja { get; set; }

        public string Nazwa { get; set; }

        public double Cena { get; set; }

        public double Wspolczynnik { get; set; }

        public string SkNazwa { get; set; }

        public string Jednostka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kosztorys> Kosztorys { get; set; }
    }
}
