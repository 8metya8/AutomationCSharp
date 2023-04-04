namespace Lesson_11
{
    internal class PriceMonitoring
    {
        Action<int> showPrice;
        public event Action<int> newLowPrice;
        int Price { get; set; }

        public PriceMonitoring(Action<int> showPrice)
        {
            this.showPrice = showPrice;
            Price = new Random().Next(300, 800);
        }

        public void SetDiscount(int discont)
        {
            Price -= discont;
            
            if( Price < 500 )
            {
                newLowPrice?.Invoke(Price);
            }
        }

        public void Show()
        {
            showPrice(Price);
        }
    }
}
