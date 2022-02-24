using ASM_Day10.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASM_Day10.DB
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Student { get; set; }
    }
}