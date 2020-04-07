namespace EasyHealth.Server
{
    using EasyHealth.Shared.Model;
    using Microsoft.EntityFrameworkCore;

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
