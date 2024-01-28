using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thread_Observer;

namespace Thread_Observer
{
    interface IObserver
    {
        void update(String state);
    }
    class ObserverA : IObserver
    {
        String state;
        public void update(String state)
        {
            this.state = state;
        }
    }
class Thread 
{
    public int id;
    String state;
    String priority;
    String culture;
    List<IObserver> observerList;
    public Thread()
    {
        this.state = "Thread Created";
        observerList = new List<IObserver>();
    }
    public void start()
    {
        this.state = "Running";
        notifyObserver();
    }
    public void abort()
    {
        this.state = "Aborted";
        notifyObserver();
    }
    public void sleep()
    {
        this.state = "sleep";
        notifyObserver();
    }
    public void suspend()
    {
        this.state = "suspended";
        notifyObserver();
    }
    public void subscribe(IObserver observer)
    {
        observerList.Add(observer);
    }
    public void unsubscribe(IObserver observer)
    {
        observerList.Remove(observer);
    }
    public void notifyObserver()
    {
        foreach(IObserver observer in observerList)
        {
            observer.update(this.state);
        }
    }

}
public class Program
    {
        static void Main(string[] args)
        {
            Thread threadObj = new Thread();
            IObserver iobserver = new ObserverA();
            threadObj.start();
            threadObj.abort();
            threadObj.sleep();
            threadObj.suspend();
            threadObj.subscribe(iobserver);
            threadObj.subscribe(iobserver);
        }
    }
}
