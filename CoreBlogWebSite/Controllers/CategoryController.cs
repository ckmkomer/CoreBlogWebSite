using Microsoft.AspNetCore.Mvc;

namespace CoreBlogWebSite.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
