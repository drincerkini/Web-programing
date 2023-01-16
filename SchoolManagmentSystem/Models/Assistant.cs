﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagmentSystem.Models
{
	public class Assistant
	{
		
            [Key]
            public int ID { get; set; }
            [Required]
            [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
            public string Name { get; set; }
            [Required]
            [StringLength(50, ErrorMessage = "Surname name cannot be longer than 50 characters")]
            public string Surname { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
            [DisplayName("Birth Date")]
            public DateTime BirthDate { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
            [DisplayName("Hire Date")]
            public DateTime HireDate { get; set; }
        public string Address { get; set; }
   
	}
}

