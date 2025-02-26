using ReposiortyPattern.Models;

namespace ReposiortyPattern.Repository
{
    public interface IStudent
    {
        public List<StudentModel> getAll();

        public StudentModel getByID(int id);
    }
}
