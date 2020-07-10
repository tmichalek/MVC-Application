namespace Zgloszenie_WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Zglaszanie_prac : DbContext
    {
        public Zglaszanie_prac()
            : base("name=Zglaszanie_prac")
        {
        }

        public virtual DbSet<AjWspol> AjWspol { get; set; }
        public virtual DbSet<Asortyment> Asortyment { get; set; }
        public virtual DbSet<Cennik> Cennik { get; set; }
        public virtual DbSet<ClWspol> ClWspol { get; set; }
        public virtual DbSet<Dokument> Dokument { get; set; }
        public virtual DbSet<Gmina> Gmina { get; set; }
        public virtual DbSet<Kosztorys> Kosztorys { get; set; }
        public virtual DbSet<KWspol> KWspol { get; set; }
        public virtual DbSet<Obreb> Obreb { get; set; }
        public virtual DbSet<Operat> Operat { get; set; }
        public virtual DbSet<PdWspol> PdWspol { get; set; }
        public virtual DbSet<Polozenie> Polozenie { get; set; }
        public virtual DbSet<Praca> Praca { get; set; }
        public virtual DbSet<Prefiks> Prefiks { get; set; }
        public virtual DbSet<RodzPracy> RodzPracy { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SuWspol> SuWspol { get; set; }
        public virtual DbSet<TWspol> TWspol { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Wykonawca> Wykonawca { get; set; }
        public virtual DbSet<Wysylka> Wysylka { get; set; }
        public virtual DbSet<X_Y> X_Y { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AjWspol>()
                .HasMany(e => e.Kosztorys)
                .WithMany(e => e.AjWspol)
                .Map(m => m.ToTable("KosztorysAjWspols").MapLeftKey("AjId").MapRightKey("KosztorysId"));

            modelBuilder.Entity<Asortyment>()
                .HasMany(e => e.Praca)
                .WithMany(e => e.Asortyment)
                .Map(m => m.ToTable("PracaAsortyments").MapLeftKey("AsortymentId").MapRightKey("PracaId"));

            modelBuilder.Entity<Cennik>()
                .HasMany(e => e.Kosztorys)
                .WithMany(e => e.Cennik)
                .Map(m => m.ToTable("KosztorysCenniks").MapLeftKey("CennikId").MapRightKey("KosztorysId"));

            modelBuilder.Entity<ClWspol>()
                .HasMany(e => e.Kosztorys)
                .WithMany(e => e.ClWspol)
                .Map(m => m.ToTable("KosztorysClWspols").MapLeftKey("ClId").MapRightKey("KosztorysId"));

            modelBuilder.Entity<Gmina>()
                .HasMany(e => e.Praca)
                .WithMany(e => e.Gmina)
                .Map(m => m.ToTable("PracaGminas").MapLeftKey("GminaId").MapRightKey("PracaId"));

            modelBuilder.Entity<Kosztorys>()
                .HasMany(e => e.KWspol)
                .WithMany(e => e.Kosztorys)
                .Map(m => m.ToTable("KosztorysKWspols").MapLeftKey("KosztorysId").MapRightKey("KId"));

            modelBuilder.Entity<Kosztorys>()
                .HasMany(e => e.PdWspol)
                .WithMany(e => e.Kosztorys)
                .Map(m => m.ToTable("KosztorysPdWspols").MapLeftKey("KosztorysId").MapRightKey("PdId"));

            modelBuilder.Entity<Kosztorys>()
                .HasMany(e => e.SuWspol)
                .WithMany(e => e.Kosztorys)
                .Map(m => m.ToTable("KosztorysSuWspols").MapLeftKey("KosztorysId").MapRightKey("SuId"));

            modelBuilder.Entity<Kosztorys>()
                .HasMany(e => e.TWspol)
                .WithMany(e => e.Kosztorys)
                .Map(m => m.ToTable("KosztorysTWspols").MapLeftKey("KosztorysId").MapRightKey("TId"));

            modelBuilder.Entity<Obreb>()
                .HasMany(e => e.Praca)
                .WithMany(e => e.Obreb)
                .Map(m => m.ToTable("PracaObrebs").MapLeftKey("ObrebId").MapRightKey("PracaId"));

            modelBuilder.Entity<Operat>()
                .HasMany(e => e.Dokument)
                .WithRequired(e => e.Operat)
                .HasForeignKey(e => e.OperatId);

            modelBuilder.Entity<Operat>()
                .HasMany(e => e.Dokument1)
                .WithRequired(e => e.Operat1)
                .HasForeignKey(e => e.OperatId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Praca>()
                .HasMany(e => e.Polozenie)
                .WithRequired(e => e.Praca)
                .HasForeignKey(e => e.PracaId);

            modelBuilder.Entity<Praca>()
                .HasMany(e => e.Polozenie1)
                .WithRequired(e => e.Praca1)
                .HasForeignKey(e => e.PracaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Praca>()
                .HasMany(e => e.Status)
                .WithMany(e => e.Praca)
                .Map(m => m.ToTable("PracaStatus").MapLeftKey("PracaId").MapRightKey("StatustId"));
        }
    }
}
