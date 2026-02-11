using Microsoft.EntityFrameworkCore;
using AHMITMTR.Models;

namespace AHMITMTR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Motor> AHMITMTR_MSTMOTOR { get; set; }
    }
}