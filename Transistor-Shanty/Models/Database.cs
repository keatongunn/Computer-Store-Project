namespace Transistor_Shanty.Models
{
    public static class Database
    {
        public static int IdCounter = 0;
        public static List<Laptop> AllLaptops { get; set; }

        public static List<Brand> AllBrands { get; set; }

        static Database()
        {
            Brand Dell = new Brand("Dell");
            Brand HP = new Brand("HP");
            Brand Acer = new Brand("Acer");
            AllBrands = new List<Brand>()
            {
                Dell, HP, Acer
            };

            //Dells
            Laptop dell1 = new Laptop(Dell, "XPS 13", 1050, new DateTime(2021, 10, 05), 5, LaptopType.New);
            Laptop dell2 = new Laptop(Dell, "G15", 1149, new DateTime(2020, 08, 22), 3, LaptopType.New);
            Laptop dell3 = new Laptop(Dell, "Latitude", 359, new DateTime(2014, 05, 19), 2, LaptopType.Refurbished);
            Laptop dell4 = new Laptop(Dell, "Inspiron 15", 850, new DateTime(2016, 03, 17), 3, LaptopType.Refurbished);
            Laptop dell5 = new Laptop(Dell, "G7", 200, new DateTime(2020, 07, 14), 4, LaptopType.Rental);

            Dell.Laptops.Add(dell1);
            Dell.Laptops.Add(dell2);
            Dell.Laptops.Add(dell3);
            Dell.Laptops.Add(dell4);
            Dell.Laptops.Add(dell5);

            //HP's
            Laptop hp1 = new Laptop(HP, "Elitebook 850 G3", 629, new DateTime(2018, 01, 05), 5, LaptopType.New);
            Laptop hp2 = new Laptop(HP, "Probook 450 G8", 1325, new DateTime(2020, 09, 17), 4, LaptopType.New);
            Laptop hp3 = new Laptop(HP, "Stream 11 Pro", 135, new DateTime(2013, 08, 11), 2, LaptopType.Refurbished);
            Laptop hp4 = new Laptop(HP, "ZBook 15 G3", 950, new DateTime(2015, 03, 03), 2, LaptopType.Refurbished);
            Laptop hp5 = new Laptop(HP, "Victus Gaming Laptop", 300, new DateTime(2021, 05, 21), 5, LaptopType.Rental);

            HP.Laptops.Add(hp1);
            HP.Laptops.Add(hp2);
            HP.Laptops.Add(hp3);
            HP.Laptops.Add(hp4);
            HP.Laptops.Add(hp5);

            //Acers
            Laptop acer1 = new Laptop(Acer, "Aspire 5", 849, new DateTime(2019, 11, 23), 5, LaptopType.New);
            Laptop acer2 = new Laptop(Acer, "Porsche Design Book RS", 1999, new DateTime(2020, 12, 15), 3, LaptopType.New);
            Laptop acer3 = new Laptop(Acer, "Swift 3", 649, new DateTime(2021, 10, 13), 5, LaptopType.Refurbished);
            Laptop acer4 = new Laptop(Acer, "Chromebook 311", 350, new DateTime(2017, 05, 06), 3, LaptopType.Refurbished);
            Laptop acer5 = new Laptop(Acer, "Nitro", 400, new DateTime(2019, 02, 19), 2, LaptopType.Rental);

            Acer.Laptops.Add(acer1);
            Acer.Laptops.Add(acer2);
            Acer.Laptops.Add(acer3);
            Acer.Laptops.Add(acer4);
            Acer.Laptops.Add(acer5);

            AllLaptops = new List<Laptop>()
            {
               acer1, 
               acer2,
               acer3,
               acer4,
               acer5,
               hp1,
               hp2,
               hp3,
               hp4,
               hp5,
               dell1,
               dell2,
               dell3,
               dell4,
               dell5
            };

        }
    }
}
