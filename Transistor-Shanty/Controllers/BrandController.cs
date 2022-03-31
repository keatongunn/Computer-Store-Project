using Microsoft.AspNetCore.Mvc;
using Transistor_Shanty.Models;

namespace Transistor_Shanty.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LaptopsPerBrand()
        {
            return View(Database.AllBrands);
        }
    }
}
