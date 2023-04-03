namespace Lesson_11
{
    internal class Flat : IObservable
    {
        List<ISubscriber> subscribers;
        string address;
        int price;

        public int Price
        {
            get
            {
                return price;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public Flat(string address, int price)
        {
            subscribers = new List<ISubscriber>();
            this.address = address;
            this.price = price;
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
            price = newPrice;
            
            NotifySubscribers();
        }
    }
}
