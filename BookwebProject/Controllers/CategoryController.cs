using BookwebProject.Data;
using BookwebProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookwebProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CategoryController(ApplicationDBContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

    }
}
