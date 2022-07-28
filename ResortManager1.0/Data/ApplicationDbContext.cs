using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Resort_Management.Models;

namespace ResortManager1._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> User { get; set; }
        public DbSet<CondosModel> Condos { get; set; }
        public DbSet<BookingModel> Bookings { get; set; }

    }
}