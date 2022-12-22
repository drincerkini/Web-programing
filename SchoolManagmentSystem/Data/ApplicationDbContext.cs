using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Models;

namespace SchoolManagmentSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SchoolManagmentSystem.Models.Department> Department { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}