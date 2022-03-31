namespace Transistor_Shanty.Models
{
    public class Brand
    {
        public int Id { get; set; }

        public static int IdCounter { get; set; } = 0;

        public List<Laptop> Laptops { get; set; }
        public string Name { get; set; }

        public Brand(string name)
        {
            Name = name;
            Laptops = new List<Laptop>();
            Id = Database.IdCounter++;
        }

        
    }
}
