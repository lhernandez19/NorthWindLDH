using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
     public class ProductController : Controller
    {
        private NorthwindContext _NorthwindContext;

        public ProductController(NorthwindContext db) => _NorthwindContext = db;

        public IActionResult Category() => View(_NorthwindContext.Categories.OrderBy(b => b.CategoryName));

        public IActionResult Discount() => View(_NorthwindContext.Discounts.OrderBy(c => c.Title));

        public IActionResult Index(int id) => View(_NorthwindContext.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));

        // public IActionResult Product(DateTime StartTime, DateTime EndTime) => View(_NorthwindContext.Discounts.Where(s => s.StartTime >= System.DateTime.Now && s.EndTime <= System.DateTime.Now).Take(3));

    }
}