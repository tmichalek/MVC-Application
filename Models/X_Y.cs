namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class X_Y
    {
        public int X_YId { get; set; }

        public DbGeometry X { get; set; }

        public DbGeometry Y { get; set; }

        public int PolozenieId { get; set; }

        public virtual Polozenie Polozenie { get; set; }
    }
}
