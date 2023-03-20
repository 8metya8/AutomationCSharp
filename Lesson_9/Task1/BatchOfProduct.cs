namespace Lesson_9
{
    internal class BatchOfProduct : IExpirationСheck, IShowInfo
    {
        string numberOfBatch;
        Product product;
        int quantity;

        public string NumberOfBatch 
        { 
            get 
            { return numberOfBatch;
            } 
        }
        public string ProductName 
        { 
            get
            {
                return product.Name;
            } 
        }

        public double Quantity
        {
            get
            {
                return quantity;
            }
        }

        public double Price
        {
            get
            {
                return product.Price * quantity;
            }
        }

        public DateTime DateOfManufacture
        {
            get
            {
                return product.DateOfManufacture;
            }
        }

        public int ShelfLife
        {
            get
            {
                return product.ShelfLife;
            }
        }

        public BatchOfProduct(string numberOfBatch, Product product, int quantity)
        {
            this.numberOfBatch = numberOfBatch;
            this.product = product;
            this.quantity = quantity;
        }

        public bool ExpirationСheck()
        {
            return product.ExpirationСheck();
        }

        public void ShowInfo()
        {
            Console.WriteLine("\n----- Batch Info -----");
            Console.WriteLine($"Number of batch: {NumberOfBatch}");
            Console.WriteLine($"Name of product: {ProductName}");
            Console.WriteLine($"Date of manufacture: {DateOfManufacture.ToShortDateString()}");
            Console.WriteLine($"Shelf life: {ShelfLife} month(s)");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Price: {Price} $");
        }
    }
}
