using ReposiortyPattern.Models;

namespace ReposiortyPattern.Repository
{
    public class StudentRepo : IStudent
    {
        public List<StudentModel> getAll()
        {
            return DataSource();
        }

        public StudentModel getByID(int id)
        {
            //return DataSource().Where(x => x.id == id).First();
            return DataSource().FirstOrDefault(x => x.id == id);

        }

        List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel{ Name= "Anup Chadn", id = 22, Gender= "Male", Standard= "3rd year"},
                new StudentModel{ Name= "aarav Chadn", id = 15, Gender= "Male", Standard= "3rd year"},
                new StudentModel{ Name= "abu Chadn", id = 16, Gender= "Male", Standard= "3rd year"},
                new StudentModel{ Name= "aabdul Chadn", id = 12, Gender= "Male", Standard= "3rd year"}
            };
        }
    }
}
