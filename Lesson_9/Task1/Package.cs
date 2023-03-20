namespace Lesson_9
{
    internal class Package : IExpirationСheck, IShowInfo
    {    
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public double Price
        {
            get
            {
                return GetPrice();
            }
        }
        
        public Package(string name, List<Product> products)
        {
            this.Name = name;
            this.Products = products;
        }

        double GetPrice()
        {
            double price = 0;

            if(Products.Count != 0)
            {
                foreach (Product product in Products)
                {
                    price += product.Price;
                }

                return price;
            }
            else return 0;
        }

        /// <summary>
        /// Return false if at least one product is expired. 
        /// </summary>
        /// <returns></returns>
        public bool ExpirationСheck()
        {
           foreach(Product product in Products)
           {
                if (product.DateOfManufacture.AddMonths(product.ShelfLife) < DateTime.Now)
                {
                    return false;
                }
           }

           return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n----- List of products -----");
            foreach (Product product in Products)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }
            Console.WriteLine(new String('-', 20));
            Console.WriteLine($"Total price: {GetPrice()} $");
        }
    }
}
