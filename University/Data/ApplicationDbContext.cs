using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Professor> professors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
