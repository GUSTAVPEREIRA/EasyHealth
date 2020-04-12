namespace EasyHealth.Server
{
    using EasyHealth.Shared.Model;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SupplyCategory> SupplyCategories { get; set; }
        public DbSet<HospitalSupply> HospitalSupplies { get; set; }
        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyCategory>().Property<DateTime>("LastUpdate")
                .HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            modelBuilder.Entity<HospitalSupply>().Property<DateTime>("LastUpdate")
                .HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
