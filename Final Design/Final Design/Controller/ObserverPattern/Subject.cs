using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Design.Controller.ObserverPattern
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify(String Notification)
        {
            foreach (IObserver observer in observers)
            {
                observer.update(Notification);
            }
        }
    }
}
