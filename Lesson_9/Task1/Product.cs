namespace Lesson_9
{
    internal class Product : IExpirationСheck, IShowInfo
    {
        string name;
        DateTime dateOfManufacture;
        int shelfLife;        
        double price;

        public string Name 
        { 
            get
            {
                return name;
            }
        }        
        public DateTime DateOfManufacture 
        {
            get 
            {
                return dateOfManufacture;
            } 
        }
        public int ShelfLife 
        { 
            get
            {
                return shelfLife;
            }
        }

        public double Price {
            get 
            {
                return price;
            }               
            set
            {
                price = value;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">Any letters and digits</param>
        /// <param name="dateOfManufacture">Date Of Manufacture</param>
        /// <param name="shelfLife">Number of months</param>
        /// <param name="price">Price in dollars.</param>
        public Product(string name, DateTime dateOfManufacture, int shelfLife, double price)
        {
            this.name = name;
            this.dateOfManufacture = dateOfManufacture;
            this.shelfLife = shelfLife;
            this.price = price;
        }

        /// <summary>
        /// If the shelf life expires return false.
        /// </summary>
        /// <returns></returns>
        public bool ExpirationСheck()
        {
            if(dateOfManufacture.AddMonths(shelfLife) > DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n----- Product Info -----");
            Console.WriteLine($"Name of product: {Name}");
            Console.WriteLine($"Date of manufacture: {DateOfManufacture.ToShortDateString()}");
            Console.WriteLine($"Shelf life: {ShelfLife} month(s)");
            Console.WriteLine($"Price: {Price} $");
        }
    }
}
