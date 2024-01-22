using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class StockObservable
    {
        public int Stock { get; set; } = 0;
        public List<INotificationObserver> observers { get; set; } = new List<INotificationObserver>();

        public string ? Name;

        public void AddSubscriber(INotificationObserver observer)
        {
            if (observer == null) { throw new Exception("Trying to add null value."); }
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void NotifySubscriber()
        {
            if (observers.Count == 0) { throw new Exception("No subscribers to notify."); }
            foreach (INotificationObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            if (observer == null) { throw new Exception("Trying to remove null value."); }
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
            else
            {
                throw new Exception("Trying to remove non-existing value.");
            }
        }

        public void Setter(int value)
        {
            if (Stock == 0 && value>0)
            {
                NotifySubscriber();
            }
            Stock += value;
        }
    }
}
