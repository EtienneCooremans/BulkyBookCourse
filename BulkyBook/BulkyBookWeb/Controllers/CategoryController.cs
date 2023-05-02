using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        // create a constructor with an implementation of ApplicationDbContext
        private readonly ApplicationDbContext _db; // create local variable so it can be used in our other action methods
        public CategoryController(ApplicationDbContext db)
        {
            _db = db; // whatever result we get from our ApplicationDbContext, will be assigned to our local variable
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList(); // run the SQL code through the database and asign the result to our list object
            return View(objCategoryList); // pass object to view
        }
    }
}
