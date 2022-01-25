using MVCApp.Models;

namespace MVCApp.Services
{
    public interface ISubjectServices
    {
        public List<Subject> GetAll();
        public bool Delete(int id);
        public Subject Get(int id);
        public int Create(Subject subject);
        public void Update(Subject subject);
    }
}
