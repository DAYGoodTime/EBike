using EBike.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace EBike.DBContext
{
    public class EBikeContext : DbContext
    {
        public EBikeContext(DbContextOptions<EBikeContext> options) : base(options) { }
        //public DbSet<Admin> adminUsers { get; set; }

        public DbSet<User> users { get; set; }

    }
}
