namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uzytkownik")]
    public partial class Uzytkownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uzytkownik()
        {
            Praca = new HashSet<Praca>();
        }

        public int UzytkownikId { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Haslo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Praca> Praca { get; set; }
    }
}
