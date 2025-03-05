using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
