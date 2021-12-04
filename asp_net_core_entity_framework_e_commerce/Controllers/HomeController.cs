using asp_net_core_entity_framework_e_commerce.DAL;
using asp_net_core_entity_framework_e_commerce.viewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace asp_net_core_entity_framework_e_commerce.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; set; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            var users = await _context.Users.ToListAsync();
            var roles = await _context.Roles.ToListAsync();
            var categories = await _context.Categories.ToListAsync();
            var brands = await _context.Brand.ToListAsync();

            HomeIndexViewModel model = new HomeIndexViewModel
            {
                products = products,
                users = users,
                roles = roles,
                categories = categories,
                brands = brands
            };
            return View(model);
        }
    }
}
