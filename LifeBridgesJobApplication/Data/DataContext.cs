using LifeBridgesJobApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LifeBridgesJobApplication.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<EmpReference> EmpRefs { get; set; }
        public DbSet<PerReference> PerRefs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var connectionString = configuration.GetConnectionString("AppDatabase");
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Application>().ToTable("Application");
            modelBuilder.Entity<PerReference>().ToTable("PerReference");
            modelBuilder.Entity<EmpReference>().ToTable("EmpReference");
        }
    }
}
