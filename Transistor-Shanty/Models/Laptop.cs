namespace Transistor_Shanty.Models
{
    public class Laptop
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }

        public int Id;

        public int Price { get; set; }
        public DateTime Year { get; set; }

        public LaptopType LaptopType { get; set; }

        public int Quantity { get; set; }

        public Laptop(Brand brand,string model, int price, DateTime year, int quantity, LaptopType type)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Year = year;
            Quantity = quantity;
            LaptopType = type;
            Id = Database.IdCounter++;
        }
    }

    public enum LaptopType
    {
        New,
        Refurbished,
        Rental
    }

}
