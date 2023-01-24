using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagmentSystem.Data;

namespace SchoolManagmentSystem.Areas.Administrator.Controllers
{
        [Area("Administrator")]
        public class AdmController : Controller
        {
        
        private readonly ILogger<AdmController> _logger;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext context;
        public AdmController(ILogger<AdmController> logger, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.roleManager = roleManager;
            this.context = context;
        }

        public IActionResult Index()
        {
            ViewBag.roles = roleManager.Roles.ToList();
            return View("~/Areas/Administrator/Views/Adm/Index.cshtml");

        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(string roleName)
        {

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                Console.WriteLine("Here");
                if (!String.IsNullOrEmpty(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
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
