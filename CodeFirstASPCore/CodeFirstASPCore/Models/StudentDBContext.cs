using Microsoft.EntityFrameworkCore;

namespace CodeFirstASPCore.Models
{
    public class StudentDBContext   : DbContext 
        //DbContext class interact with the Database 
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Student> Students { get; set; }        
             //It will represt the database table
    }
}
