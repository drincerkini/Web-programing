using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagmentSystem.Data;

namespace SchoolManagmentSystem.Areas.Administrator.Controllers
{
<<<<<<< HEAD
    [Area("Administrator")]
    public class AdmController : Controller
    {

=======
        [Area("Administrator")]
        public class AdmController : Controller
        {
        
>>>>>>> 422e7dc2df4cfc76722c1f895522c37cda4af393
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
<<<<<<< HEAD

        }
=======

        }

>>>>>>> 422e7dc2df4cfc76722c1f895522c37cda4af393
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
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
                    await context.SaveChangesAsync();
                }
            }

            return RedirectToAction(nameof(Index));

        }
  
    }
  
}

