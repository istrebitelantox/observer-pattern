using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibSkeletons;

namespace SolSkeleton
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ConcreteObserver> observers = new List<ConcreteObserver>() { new ConcreteObserver(), new ConcreteObserver() };
            ConcreteSubject subject = new ConcreteSubject();

            subject.registerObserver(observers[0]);
            subject.setState("Юрий");
            CounterInConsole(observers);
            subject.registerObserver(observers[1]);
            subject.setState("Павел");
            CounterInConsole(observers);
            subject.removeObserver(observers[1]);
            subject.setState("Павел");
            CounterInConsole(observers);

            Console.ReadKey();
        }
        private static void CounterInConsole(List<ConcreteObserver> observers)
        {
            foreach (ConcreteObserver observer in observers) Console.Write(observer.GetCounter() + " ");
            Console.WriteLine();
        }
    }
}
