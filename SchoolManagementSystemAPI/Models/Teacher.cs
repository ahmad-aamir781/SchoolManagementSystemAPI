using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Teacher
    {
        [Key]
        public int T_id { get; set; }

        //[Required(ErrorMessage ="Name is required.")]
        public string? Teacher_Name{ get; set; }


        //[Required(ErrorMessage ="Date of joining is required.")]
        //[DataType(DataType.Date)]
        public DateOnly Date_of_joining{ get; set; }


        //[Required(ErrorMessage ="Email is required.")]
        public string? Email { get; set; }


        //[Required(ErrorMessage ="Salary is required.")]
        public int Salary {  get; set; }


        public ICollection<Class>? Class { get; set; }
        
        public ICollection<Subject>? Subject { get; set; }

    }
}
