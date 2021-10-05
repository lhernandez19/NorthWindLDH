using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
     public class ProductController : Controller
    {
         // this controller depends on the NorthwindRepository
        private NorthwindContext _NorthwindContext;
        public ProductController(NorthwindContext db) => _NorthwindContext = db;
        public IActionResult Category() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));
        public IActionResult Index(int id) => View(_NorthwindContext.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));
    }
}