using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        public DbSet<User> Users { set; get; }

        public DbSet<Character> Characters { set; get; }
    }
 
}
