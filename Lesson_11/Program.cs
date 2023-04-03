namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //With event
            Console.WriteLine("--- Event ----");
            PriceMonitoring monitoring = new PriceMonitoring(ShowPrice);
            monitoring.Show();
            monitoring.newLowPrice += PriceDecreased;
            monitoring.SetDiscount(300);

            //Patern Observer
            Console.WriteLine("\n--- Patern Observer ---");
            Flat flat = new Flat("Minsk, str. Vaneeva, 28", 800);
            Realtor realtor = new Realtor(500);
            Realtor realtor2 = new Realtor(400);

            flat.AddObserver(realtor);
            flat.AddObserver(realtor2);
            flat.SetNewPrice(450);
            flat.SetNewPrice(400);
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"Current price is {price}$");
        }

        public static void PriceDecreased(int price)
        {
            Console.WriteLine("Price has been decreased!");
            Console.WriteLine($"New price - {price}$");
        }
    }
}