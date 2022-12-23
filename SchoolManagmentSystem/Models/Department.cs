using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace SchoolManagmentSystem.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        
        public string Name { get; set; }
        [Required (ErrorMessage ="Description cannot be blank")]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("CreatedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }

    }
}
