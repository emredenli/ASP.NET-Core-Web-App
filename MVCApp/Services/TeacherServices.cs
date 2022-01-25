using MVCApp.Context;
using MVCApp.Models;

namespace MVCApp.Services
{
    public class TeacherServices : ITeacherServices
    {

        private MVCContext _db;

        public TeacherServices(MVCContext db)
        {
            _db = db;
        }

        public int Create(Teacher teacher)
        {
            _db.Teachers.Add(teacher);
            _db.SaveChanges();
            return teacher.TeacherId;
        }

        public bool Delete(int id)
        {
            try
            {
                Teacher teacher = Get(id);
                _db.Teachers.Remove(teacher);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Teacher Get(int id)
        {
            Teacher teacher = _db.Teachers.FirstOrDefault(x => x.TeacherId == id);
            return teacher;
        }

        public List<Teacher> GetAll()
        {
            List<Teacher> list = _db.Teachers.Select(x => x).ToList();
            return list;
        }

        public void Update(Teacher teacher)
        {
            _db.Teachers.Update(teacher);
            _db.SaveChanges();
        }
    }
}
