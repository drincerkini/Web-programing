using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagmentSystem.Models;

namespace SchoolManagmentSystem.ViewModels
{
    public class TeacherFilterViewModel
    {
        public List<Teacher>? Teachers { get; set; }
        public SelectList? Genders { get; set; }
        public string? TeacherGender { get; set; }
        public string? SearchString { get; set; }
    }
}
