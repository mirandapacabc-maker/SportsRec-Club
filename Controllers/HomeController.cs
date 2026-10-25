using Microsoft.AspNetCore.Mvc;

namespace SportsRec.Club.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}