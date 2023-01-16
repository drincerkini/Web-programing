using System.ComponentModel.DataAnnotations;

namespace SchoolManagmentSystem.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [Range(0, 5)]
        public int Credits { get; set; }
    }
}
