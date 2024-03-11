using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorID { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public String ProfessorName { get; set; }
    }
}
