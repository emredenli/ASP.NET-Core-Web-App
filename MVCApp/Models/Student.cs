using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }
    }
}
