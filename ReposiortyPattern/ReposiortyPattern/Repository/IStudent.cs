using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public interface IStudent
    {
        public List<StudentModel> getAll();

        public StudentModel getByID(int id);
    }
}
