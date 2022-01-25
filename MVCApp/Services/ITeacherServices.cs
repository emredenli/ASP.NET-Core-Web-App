using MVCApp.Models;

namespace MVCApp.Services
{
    public interface ITeacherServices
    {
        public List<Teacher> GetAll();
        public Teacher Get(int id);
        public bool Delete(int id);
        public int Create(Teacher teacher);
        public void Update(Teacher teacher);
    }
}
