using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStoreProject.Data;

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