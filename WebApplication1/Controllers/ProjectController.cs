using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
