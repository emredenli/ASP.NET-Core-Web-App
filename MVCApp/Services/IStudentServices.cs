using MVCApp.Models;

namespace MVCApp.Services
{
    public interface IStudentServices
    {
        public List<Student> GetAll();
        public bool Delete(int id);
        public Student Get(int id);
        public int Create(Student student);
        public void Update(Student student);
    }
}
