using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStoreProject.Data;

namespace WebStoreProject.Controllers
{
    public class HomeController : Controller
    {
        StoreDataContext db;

        public HomeController(StoreDataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}