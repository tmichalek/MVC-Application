namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kosztorys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kosztorys()
        {
            AjWspol = new HashSet<AjWspol>();
            Cennik = new HashSet<Cennik>();
            ClWspol = new HashSet<ClWspol>();
            KWspol = new HashSet<KWspol>();
            PdWspol = new HashSet<PdWspol>();
            SuWspol = new HashSet<SuWspol>();
            TWspol = new HashSet<TWspol>();
        }

        public int KosztorysId { get; set; }

        public short NrCennika { get; set; }

        public double Pozycja { get; set; }

        public string Nazwa { get; set; }

        public short Ilosc { get; set; }

        public double Cena { get; set; }

        public double Wspolczynnik { get; set; }

        public double Vat { get; set; }

        public double Brutto { get; set; }

        public int KId { get; set; }

        public int ClId { get; set; }

        public int SuId { get; set; }

        public int PdId { get; set; }

        public int AjId { get; set; }

        public int TId { get; set; }

        public int CennikId { get; set; }

        public int PracaId { get; set; }

        public int WysylkaId { get; set; }

        public int Numer { get; set; }

        public int Rok { get; set; }

        public virtual Praca Praca { get; set; }

        public virtual Wysylka Wysylka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AjWspol> AjWspol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cennik> Cennik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClWspol> ClWspol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KWspol> KWspol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdWspol> PdWspol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuWspol> SuWspol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TWspol> TWspol { get; set; }
    }
}
