using MVCApp.Context;
using MVCApp.Models;

namespace MVCApp.Services
{
    public class SubjectServices : ISubjectServices
    {
        private MVCContext _db;
        public SubjectServices(MVCContext db)
        {
            _db = db;
        }

        public int Create(Subject subject)
        {
            _db.Subjects.Add(subject);

            _db.SaveChanges();

            return subject.SubjectId;
        }

        public bool Delete(int id)
        {
            try
            {
                Subject subject = Get(id);
                _db.Subjects.Remove(subject);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
           
            return true; 
            
        }

        public Subject Get(int id)
        {
            Subject subject = _db.Subjects.FirstOrDefault(x => x.SubjectId == id);
            return subject;
        }

        public List<Subject> GetAll()
        {
            List<Subject> list = _db.Subjects.Select(x => x).ToList();

            return list;
        }

        public void Update(Subject subject)
        {
            _db.Subjects.Update(subject);

            _db.SaveChanges();
        }

    }
}
