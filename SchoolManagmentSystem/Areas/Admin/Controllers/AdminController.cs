using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Data;

namespace SchoolManagmentSystem.Areas.Admin.Administrator
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext context;
        public AdminController(ILogger<AdminController> logger, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.roleManager = roleManager;
            this.context = context;
        }
        public IActionResult Index()
        {
            ViewBag.roles = roleManager.Roles.ToList();
            return View();
        }

        public async Task<IActionResult> ListUsers()
        {
            var users = await context.Users.ToListAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(string roleName)
        {

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                if (!String.IsNullOrEmpty(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> DeleteRole(string roleName)
        {
            if (!String.IsNullOrEmpty(roleName))
            {
                if (await roleManager.RoleExistsAsync(roleName))
                {
                    var role = await roleManager.FindByNameAsync(roleName);
                    await roleManager.DeleteAsync(role);
                }
            }

            return RedirectToAction(nameof(Index));

        }

    }
}
