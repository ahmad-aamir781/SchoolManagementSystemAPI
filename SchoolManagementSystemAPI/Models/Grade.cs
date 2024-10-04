using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Grade
    {
        [Key]
        public int Grd_id { get; set; }


        //[Required(ErrorMessage ="Type is Required")]
        public string? Grd_Type { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
