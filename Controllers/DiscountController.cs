using System;
using Northwind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Northwind.Controllers{

    public class DiscountController : Controller
    {
        private NorthwindContext _NorthwindContext;

        public DiscountController(NorthwindContext db) => _NorthwindContext = db;


         public ActionResult Product() => View(_NorthwindContext.Discounts);

        // public IActionResult Product(DateTime StartTime, DateTime EndTime) => View(_NorthwindContext.Discounts.Where(s => s.StartTime >= System.DateTime.Now && s.EndTime <= System.DateTime.Now).Take(3)); 
    }
}