using Microsoft.EntityFrameworkCore;
using MVCApp.Models;

namespace MVCApp.Context
{
    public class MVCContext:DbContext
    {
        public MVCContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

    }
}
