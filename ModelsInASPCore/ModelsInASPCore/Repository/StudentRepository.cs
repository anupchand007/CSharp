using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentByAge(int age)
        {
            return DataSource().Where(x => x.Age == age).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {

               new StudentModel{ Name = "Anup Chand", Age = 22, Standard = "Bachelor 3rd year", Gender = "Male" },

               new StudentModel{ Name = "Puspa Chand", Age = 20, Standard = "Bachelor 1st year", Gender = "Female" },

               new StudentModel{ Name = "Aarav Chand", Age = 25, Standard = "Masters", Gender = "Male" }
            };
        }
    }
}
