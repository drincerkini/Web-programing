using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagmentSystem.Models
{
        public enum Grade
        {
            A, B, C, D, F
        }

        public class Enrollment
        {
            public int EnrollmentID { get; set; }
            [DisplayFormat(NullDisplayText = "No grade")]
            public Grade? Grade { get; set; }

        //relationships
            public int CourseID { get; set; }
            public int StudentID { get; set; }
            [ForeignKey("CourseID")]
            public Course? Course { get; set; }
            [ForeignKey("StudentID")]
            public Student? Student { get; set; }
                
        }
    }


