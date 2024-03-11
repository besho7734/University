using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int ProfessorID { get; set; }
        [ForeignKey("ProfessorID")]
        public virtual ICollection<Student> Students  { get; set; }

    }
}
