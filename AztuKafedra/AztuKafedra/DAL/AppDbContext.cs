using AztuKafedra.Models;
using Microsoft.EntityFrameworkCore;

namespace AztuKafedra.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ParentCategory> Parentcategory { get; set; }
        public DbSet<ChildCategory> ChildCategory { get; set; }
        public DbSet<BigParentsCategory> BigParentsCategory { get; set; }
    }
}
