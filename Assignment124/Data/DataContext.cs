using Microsoft.EntityFrameworkCore;

namespace Assignment124.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enroll> Enroll { get; set; }
    }
}
