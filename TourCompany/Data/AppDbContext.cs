using Microsoft.EntityFrameworkCore;
using TourCompany.Models;

namespace TourCompany.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PontosTuristicos> PontosTuristicos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
