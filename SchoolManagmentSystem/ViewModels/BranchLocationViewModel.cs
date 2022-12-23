using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagmentSystem.Models;

namespace SchoolManagmentSystem.ViewModels
{
    public class BranchLocationViewModel
    {
        public List<Branch>? Branches { get; set; }
        public SelectList? Locations { get; set; }
        public string? BranchLocation { get; set; }
        public string? SearchString { get; set; }
    }
}
