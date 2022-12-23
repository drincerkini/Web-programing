using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SchoolManagmentSystem.Models
{
    public class Branch
    {
        public int ID { get; set; }

        [Required]
        [DisplayName("Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]

        public string Name { get; set; }

        [Required]
        [DisplayName("Location")]
        [StringLength(20, ErrorMessage = "Name cannot be longer than 20 characters")]

        public string Location { get; set; }

        [Required]
        [DisplayName("CreatedDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime CreatedDate { get; set; }
    }
}
