using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStoreProject.Data;
using WebStoreProject.Models;

namespace WebStoreProject.Controllers
{
    public class ProductController : Controller
    {
        StoreDataContext db;
        public ProductController(StoreDataContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Products.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}