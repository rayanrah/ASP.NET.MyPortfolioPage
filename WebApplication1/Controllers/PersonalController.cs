using Microsoft.AspNetCore.Mvc;
using MY_PORTFOLIO.Models;

namespace MY_PORTFOLIO.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View(new PersonalVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //With the 'Post method' you can send as much as data you want because the Data store in the budy request.  
        public IActionResult ShowPersonal(PersonalVM personalVM)

        {
            return View(personalVM);
        }
    }
}