using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;


namespace Northwind.Controllers
{
    public class HomeController : Controller
    
    {
        private NorthwindContext _NorthwindContext;
        public HomeController(NorthwindContext db) => _NorthwindContext = db;

        // public ActionResult Index() => View();

        public ActionResult Index() => View(_NorthwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));
    }
}