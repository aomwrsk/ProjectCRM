using Microsoft.EntityFrameworkCore;
using ProjectCRM.Models;

namespace ProjectCRM.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        // Define your DbSets (tables) here
        public DbSet<Permission> a_user { get; set; }
    }
}
