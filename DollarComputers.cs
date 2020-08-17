namespace COMP123_Assignment5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DollarComputers : DbContext
    {
        public DollarComputers()
            : base("name=DollarComputersConnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
