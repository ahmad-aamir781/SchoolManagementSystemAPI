using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Subject
    {
        [Key]
        public int Sbj_id { get; set; }
        //[Required(ErrorMessage ="Name is required.")]
        public string? Sbj_Name { get; set; }

        public ICollection<Student>? Students { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
    }
}
