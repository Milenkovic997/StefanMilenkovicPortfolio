using Microsoft.AspNetCore.Mvc;

namespace StefanMilenkovic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}