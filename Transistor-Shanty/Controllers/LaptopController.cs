using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Transistor_Shanty.Models;
using Transistor_Shanty.ViewModels;

namespace Transistor_Shanty.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", Database.AllLaptops);
        }

        //Displays the two most expensive laptops.
        public IActionResult TopTwoPrice()
        {
            var topTwo = Database.AllLaptops.OrderByDescending(x => x.Price).Take(2).ToList();
            return View("Index", topTwo);
        }

        //Displays the three cheapest laptops
        public IActionResult CheapThree()
        {
            var bottomThree = Database.AllLaptops.OrderBy(x => x.Price).Take(3).ToList();
            return View("Index", bottomThree);
        }
        //Creates a laptop
        public IActionResult CreateLaptop()
        {
            LaptopAndBrandViewModel vm = new LaptopAndBrandViewModel(Database.AllLaptops, Database.AllBrands);
            return View(vm);
        }

        [HttpPost]
        public IActionResult CreateLaptop(int brandId, string model, int price, DateTime year, int quantity, LaptopType type)
        {
            if(brandId == null || model == null || price == null || year == null || quantity == null || type == null)
            {
                return View("ErrorPage");
            }
            Brand brandChosen = Database.AllBrands.First(b => b.Id == brandId);
            Laptop newLaptop = new Laptop(brandChosen, model, price, year, quantity, type);
            Database.AllLaptops.Add(newLaptop);
            brandChosen.Laptops.Add(newLaptop);
            return RedirectToAction("Index");
        }

        //Groups by laptop types
        public IActionResult GroupByType()
        {
            var typeGrouped = Database.AllLaptops.GroupBy(m => m.LaptopType);
            return View(typeGrouped);
        }

        //Filters for laptops the customer can afford
        public IActionResult PriceFilter()
        {
            return View(Database.AllLaptops);
        }

        [HttpPost]
        public IActionResult PriceFilter(int price)
        {
            var LaptopsUnderPrice = Database.AllLaptops.Where(laptop => laptop.Price <= price).ToList();

            
            return View("Index", LaptopsUnderPrice);
        }

        //Compares two laptops
        public IActionResult CompareLaptops()
        {
            LaptopAndBrandViewModel vm = new LaptopAndBrandViewModel(Database.AllLaptops, Database.AllBrands);
            return View(vm);
        }

        [HttpPost]
        public IActionResult CompareLaptops(int lap1, int lap2)
        {
            
            Laptop laptop1 = Database.AllLaptops.First(b => b.Id == lap1);
            Laptop laptop2 = Database.AllLaptops.First(l => l.Id == lap2);
            List<Laptop> comparison = new List<Laptop>();
            comparison.Add(laptop1);
            comparison.Add(laptop2);
            return View("Index", comparison);
        }

        //
        public IActionResult YearPriceSort()
        {
            LaptopAndBrandViewModel vm = new LaptopAndBrandViewModel(Database.AllLaptops, Database.AllBrands);
            return View(vm);
        }

        [HttpPost]
        public IActionResult YearPriceSort(int dateId, DateTime filter, int numId, int price)
        {
            
            if(dateId == 0 && numId == 0)
            {
                 return View("Index", Database.AllLaptops.Where(laptop => laptop.Year >= filter && laptop.Price >= price).ToList());
            }
            if(dateId ==0 && numId == 1)
            {
                 return View("Index", Database.AllLaptops.Where(laptop => laptop.Year >= filter && laptop.Price <= price).ToList()); 
            }
            if(dateId==1 && numId == 0)
            {
                 return View("Index", Database.AllLaptops.Where(laptop => laptop.Year <= filter && laptop.Price >= price).ToList()); 
            }
            if(dateId==1 && numId == 1)
            {
                 return View("Index", Database.AllLaptops.Where(laptop => laptop.Year <= filter && laptop.Price <= price).ToList());
            }else
            {
                return View("ErrorPage");
            }

            return View("Index");
        }

        public IActionResult BrandDescend()
        {
            LaptopAndBrandViewModel vm = new LaptopAndBrandViewModel(Database.AllLaptops, Database.AllBrands);
            return View(vm);  
        }

        [HttpPost]
        public IActionResult BrandDescend(int brandId, int filterId)
        {
            Brand brandChosen = Database.AllBrands.First(brand => brand.Id == brandId);
            if (filterId == 0)
            {
                return View("Index", Database.AllLaptops.Where(laptop => laptop.Brand == brandChosen).OrderByDescending(laptop => laptop.Price).ToList());
            }
            if(filterId == 1)
            {
                return View("Index", Database.AllLaptops.Where(laptop => laptop.Brand == brandChosen).OrderByDescending(laptop => laptop.Year).ToList());
            }
            else
            {
                return View("ErrorPage");
            }

            return View("Index");
        }

        public IActionResult Pages()
        {
            return View();
        }



    }
}
