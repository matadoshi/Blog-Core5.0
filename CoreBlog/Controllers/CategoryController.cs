using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
