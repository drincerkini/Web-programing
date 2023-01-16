using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
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
        public DateTime CreatedDate { get; set; }
    }
}
