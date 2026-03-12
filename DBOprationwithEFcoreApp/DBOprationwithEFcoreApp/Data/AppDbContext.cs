using Microsoft.EntityFrameworkCore;

namespace DBOprationwithEFcoreApp.Data
{
        public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
    }
}
