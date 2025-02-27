using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore.Models
{
    public class Student
    {
        [Key]                       //ID will be treated as Primary Key
        public int ID { get; set; }

        [Column("Student Name", TypeName = "varchar(100)")]        //Student Name column will be generated
        public string Name { get; set; }

        [Column("Gender", TypeName = "varchar(20)")]
        public string Gender { get; set; }

        [Column("Age", TypeName = "varchar(10)")]
        public int Age { get; set; }

        public int Standard { get; set; }
    }
}
