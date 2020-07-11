using In_class_Many_many_relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace In_class_Many_many_relationships.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Students> students { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<StudentCourseEnrollment> studentCourseEnrollment { get; set; }

    }
}
