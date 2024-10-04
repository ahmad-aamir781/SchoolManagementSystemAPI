using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Term
    {
        [Key]
        public int Trm_id { get; set; }

        //[Required(ErrorMessage ="Date required")]
        //[DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }


        //[Required(ErrorMessage ="Date required")]
        //[DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}
