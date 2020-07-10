namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Praca")]
    public partial class Praca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Praca()
        {
            Kosztorys = new HashSet<Kosztorys>();
            Operat = new HashSet<Operat>();
            Polozenie = new HashSet<Polozenie>();
            Polozenie1 = new HashSet<Polozenie>();
            Asortyment = new HashSet<Asortyment>();
            Gmina = new HashSet<Gmina>();
            Obreb = new HashSet<Obreb>();
            Status = new HashSet<Status>();
        }

        public int PracaId { get; set; }

        public short Numer { get; set; }

        public short Rok { get; set; }

        public DateTime DataZgloszenia { get; set; }

        public DateTime DataZakonczeniaPrac { get; set; }

        public string PolozenieOpis { get; set; }

        public int CharakterOb { get; set; }

        public bool Aktualne { get; set; }

        public int PrefiksId { get; set; }

        public int GminaId { get; set; }

        public int ObrebId { get; set; }

        public int UzytkownikId { get; set; }

        public int WykonawcaId { get; set; }

        public int AsortymentId { get; set; }

        public int StatusId { get; set; }

        public int PolozenieId { get; set; }

        public int RodzpracyId { get; set; }

        public string NumerDzialki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kosztorys> Kosztorys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operat> Operat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Polozenie> Polozenie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Polozenie> Polozenie1 { get; set; }

        public virtual RodzPracy RodzPracy { get; set; }

        public virtual Prefiks Prefiks { get; set; }

        public virtual Uzytkownik Uzytkownik { get; set; }

        public virtual Wykonawca Wykonawca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asortyment> Asortyment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gmina> Gmina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obreb> Obreb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }
    }
}
