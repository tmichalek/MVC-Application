namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wykonawca")]
    public partial class Wykonawca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wykonawca()
        {
            Praca = new HashSet<Praca>();
        }

        public int WykonawcaId { get; set; }

        public string NazwaFirmy { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string AdresMiejscowosc { get; set; }

        public int AdresKod { get; set; }

        public string AdresUlica { get; set; }

        public short NumerBudynku { get; set; }

        public short? NumerLokalu { get; set; }

        public int Nip { get; set; }

        public int Regon { get; set; }

        public int NrTelefonu { get; set; }

        public short NrUprawnien { get; set; }

        public string AdresEmail { get; set; }

        public string ZakresUprawnien { get; set; }

        public string Login { get; set; }

        public string Haslo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Praca> Praca { get; set; }
    }
}
