namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dokument")]
    public partial class Dokument
    {
        public int DokumentId { get; set; }

        public int NazwaDok { get; set; }

        public int OperatId { get; set; }

        public string NumerDokumentu { get; set; }

        public virtual Operat Operat { get; set; }

        public virtual Operat Operat1 { get; set; }
    }
}
