using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindContext _NorthwindContext;
        public CustomerController(NorthwindContext db) => _NorthwindContext = db;
        public IActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Register (Customer model)
        {
            if (ModelState.IsValid)
            {
                if(_NorthwindContext.Customers.Any(c => c.CompanyName == model.CompanyName))
                {
                    ModelState.AddModelError("", "Company already exists");
                }
                else
                {
                    
                    _NorthwindContext.Register(model);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }  
}