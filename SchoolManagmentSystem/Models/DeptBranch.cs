using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagmentSystem.Models
{
    public class DeptBranch
    {
        public int DeptBranchID { get; set; }

        //relationships
        public int DepartmentID { get; set; }
        public int BranchID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department? Department { get; set; }
        [ForeignKey("BranchID")]
        public Branch? Branch { get; set; }
    }
}

