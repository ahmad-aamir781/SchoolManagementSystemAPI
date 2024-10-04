using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Student
    {
        [Key]
        public int Std_id { get; set; }

        public string? Std_Name{ get; set; }

        public string? Std_Gender { get; set; }

        public int Std_Age { get; set; }

        //public ICollection<Class>? Classes { get; set; }
        //public ICollection<Teacher>? Teachers { get; set; }
        //public ICollection<Term>? Terms { get; set; }
        //public ICollection<Grade>? Grades { get; set; }
        //public ICollection<Subject>? Subjects { get; set; }
    }
}
    