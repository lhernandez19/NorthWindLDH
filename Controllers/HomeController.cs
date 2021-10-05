using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Northwind.Controllers
{
     public class HomeController : Controller
    {
        public IActionResult Index() => View();
        
    }
}