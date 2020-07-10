namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operat")]
    public partial class Operat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operat()
        {
            Dokument = new HashSet<Dokument>();
            Dokument1 = new HashSet<Dokument>();
        }

        public int OperatId { get; set; }

        public int OznCzesciZasobu { get; set; }

        public short Oznaczenie2 { get; set; }

        public int Rok { get; set; }

        public int Numer { get; set; }

        public int NazwaMat { get; set; }

        public int RodzajNosnikaNielektroniczny { get; set; }

        public int Postac { get; set; }

        public int TypMaterialu { get; set; }

        public int KatArchiw { get; set; }

        public DateTime DataArch { get; set; }

        public int? SposobPozyskania { get; set; }

        public int InfoODostepie { get; set; }

        public int PracaId { get; set; }

        public string Jezyk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokument> Dokument { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokument> Dokument1 { get; set; }

        public virtual Praca Praca { get; set; }
    }
}
