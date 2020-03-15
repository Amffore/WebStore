using Microsoft.AspNetCore.Mvc;

namespace WebStoreProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}