namespace Lesson_11
{
    internal interface IObservable
    {
        void AddObserver(ISubscriber subscriber);
        void RemoveObserver(ISubscriber subscriber);
        void NotifySubscribers();
    }
}
