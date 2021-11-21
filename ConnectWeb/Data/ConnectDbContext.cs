using ConnectWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectWeb.Data
{
    public class ConnectDbContext : DbContext
    {
        public ConnectDbContext(DbContextOptions<ConnectDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Client> client { get; set; }
        public DbSet<UserType> userTypes { get; set; }
        public DbSet<ClientLocation> clientLocations { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Password> passwords { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<RateType> rateTypes { get; set; }
        public DbSet<ReasonCode> reasonCodes { get; set; }
        public DbSet<Shift> shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shift>(entity =>
            {
               

                
            });
        }
    }
}
