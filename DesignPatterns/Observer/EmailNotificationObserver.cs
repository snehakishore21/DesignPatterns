using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class EmailNotificationObserver : INotificationObserver
    {
        public string Email { get; set; }

        public StockObservable Observable { get; set; }

        public EmailNotificationObserver(string email, StockObservable observable)
        {
            Email = email;
            Observable = observable;
            observable.AddSubscriber(this);
        }
        public void Update()
        {
            Console.WriteLine("Email notification sent to " + Email + " for " + Observable.Name);
        }
    }
}
