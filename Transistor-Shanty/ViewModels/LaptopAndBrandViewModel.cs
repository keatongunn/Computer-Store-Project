using Transistor_Shanty.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Transistor_Shanty.ViewModels
{
    public class LaptopAndBrandViewModel
    {
        public List<SelectListItem> higherLower { get; set; } 

        public List<SelectListItem> filterList { get; set; }
        public List<SelectListItem> SelectListBrands { get; set; }   

        public List<SelectListItem> SelectListLaptops { get; set; }
        public List<Laptop> Laptops { get; set; }
        public List<Brand> Brands { get; set; }

        public LaptopAndBrandViewModel(List<Laptop> laptop, List<Brand> brands)
        {
            Laptops = laptop;
            Brands = brands;
            SelectListBrands = new List<SelectListItem>();
            SelectListLaptops = new List<SelectListItem>();
            filterList = new List<SelectListItem>
            {
                new SelectListItem("Order By Price", "0"),
                new SelectListItem("Order By Year", "1")

            };
            higherLower = new List<SelectListItem>
            {
                new SelectListItem("Higher Than", "0"),
                new SelectListItem("Lower Than", "1")
            };

            foreach(var item in Laptops)
            {
                SelectListLaptops.Add(new SelectListItem(item.Model, item.Id.ToString()));
            }


            foreach(var item in Brands)
            {
                SelectListBrands.Add(new SelectListItem(item.Name, item.Id.ToString()));

            }
        }

        
        
    }
}
