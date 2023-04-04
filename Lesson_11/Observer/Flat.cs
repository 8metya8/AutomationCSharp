namespace Lesson_11
{
    internal class Flat : IObservable
    {
        List<ISubscriber> subscribers;

        public int Price { get; set; }

        public string Address { get; }

        public Flat(string address, int price)
        {
            subscribers = new List<ISubscriber>();
            this.Address = address;
            this.Price = price;
        }

        public void AddObserver(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void NotifySubscribers()
        {
            Console.WriteLine("\n--- Notify Subscribers --");
            
            foreach(var subscriber in subscribers)
            {
                    subscriber.Update(this);         
            }
        }

        public void RemoveObserver(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SetNewPrice(int newPrice)
        {
            Price = newPrice;
            
            NotifySubscribers();
        }
    }
}
