namespace assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_3> Table_3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.cars)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.companyname)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .HasMany(e => e.Table_3)
                .WithRequired(e => e.Table_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_3>()
                .Property(e => e.cars)
                .IsUnicode(false);

            modelBuilder.Entity<Table_3>()
                .Property(e => e.company)
                .IsUnicode(false);
        }
    }
}
