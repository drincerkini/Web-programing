using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagmentSystem.Models
{
	public class Student
	{
		[Key]
		public int ID { get; set; }
		[Required]
		[DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; }
		[Required]
		[DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
		public string LastName { get; set; }
		[Required]
		[DisplayName("Birth Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
		public DateTime BirthDate { get; set; }
		public string Address { get; set; }
		public char Gender { get; set; }
		public string PhoneNumber { get; set; }

	}
}

