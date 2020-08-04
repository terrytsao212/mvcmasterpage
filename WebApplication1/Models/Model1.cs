namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Members> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Members)
                .HasForeignKey(e => e.MemberId);
        }
    }
}
