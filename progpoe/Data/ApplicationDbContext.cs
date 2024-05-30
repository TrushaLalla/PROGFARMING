using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using progpoe.Models;

namespace progpoe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<progpoe.Models.Farmer> Farmer { get; set; } = default!;
        public DbSet<progpoe.Models.Employee> Employee { get; set; } = default!;
       // public DbSet<progpoe.Models.Farmer> Farmer_1 { get; set; } = default!;
    }
}
