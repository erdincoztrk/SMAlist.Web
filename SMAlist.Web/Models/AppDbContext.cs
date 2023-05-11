using Microsoft.EntityFrameworkCore;

namespace SMAlist.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Person> SMA { get; set; }
        public DbSet<Form> SMA_Form { get; set; }
    }
}
