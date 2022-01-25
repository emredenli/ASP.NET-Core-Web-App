using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models
{
    public class Subject
    {
        
        [Key]
        public int SubjectId { get; set; }

        public string? SubjectName { get; set; }
        public string SubjectTerm { get; set; }
        public int SubjectCredets { get; set; }

        public List<Teacher> SubjectTeachers { get; set; } = new List<Teacher>();
    }
}
