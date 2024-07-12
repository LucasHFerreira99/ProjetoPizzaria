using Microsoft.EntityFrameworkCore;

namespace ProjetoPizzaria.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly DbContext _dbContext;

        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
