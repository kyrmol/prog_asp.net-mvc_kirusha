using Microsoft.AspNetCore.Mvc;

namespace prog_asp.net_mvc_kirusha.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
