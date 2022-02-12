using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSkeletons
{
    public class ConcreteSubject : ISubject
    {
        string Jacob;
        List<IObserver> observers = new List<IObserver>();
        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in observers) observer.update();
        }
        public string getState() 
        {
            return Jacob;
        }
        public void setState(string jacob) 
        {
            Jacob = jacob;
            notifyObservers();
        }
    }
}
