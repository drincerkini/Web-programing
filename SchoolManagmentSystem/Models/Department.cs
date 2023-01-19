using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace SchoolManagmentSystem.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25, ErrorMessage ="Name cannot be longer than 25 characters")]
        public string  Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }

        // relationship
        public int ProfessorID { get; set; }
        [ForeignKey("ProfessorID")]
        public Professor? Professor { get; set; }
        public ICollection<Course>? Courses { get; set; }
        

    }
}
