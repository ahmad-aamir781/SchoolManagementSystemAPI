using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Class
    {
        [Key]
        public int Class_id { get; set; }
        //[Required(ErrorMessage ="Class is required.")]
        public int Class_number { get; set; }

        public ICollection<Student>? Students { get; set; } = null;

        public ICollection<Teacher>? Teachers { get; set; } = null;
    }
}
