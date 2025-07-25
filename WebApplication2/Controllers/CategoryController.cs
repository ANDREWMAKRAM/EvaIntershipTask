using Microsoft.AspNetCore.Mvc;
using Task1_eva.DataAccess;
using Task1_eva.Models;
using System.Linq;

namespace Task1_eva.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Category/
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories); // This will load Views/Category/Index.cshtml
        }

        // GET: /Category/Create
        public IActionResult Create()
        {
            return View(); // This will load Views/Category/Create.cshtml
        }

        // POST: /Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreatedDate = DateTime.Now;
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category); // Reload form with validation messages
        }
    }
}
