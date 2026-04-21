using ConsultaHub.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsultaHub.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
