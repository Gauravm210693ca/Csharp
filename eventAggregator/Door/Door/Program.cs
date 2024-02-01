using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Door
{
    public class Program
    {
        static void Main(string[] args)
        {
            EventAggregator eventAggregator = new EventAggregator();

            SimpleDoor simpleDoor = new SimpleDoor();
            TimerManager timerManager = new TimerManager(eventAggregator);
            SmartDoor smartDoor = new SmartDoor(timerManager, eventAggregator);

            BuzzerManager buzzerManager = new BuzzerManager(eventAggregator);
            PagerManager pagerManager = new PagerManager(eventAggregator);
            AutoCloseManager autoCloseManager = new AutoCloseManager(eventAggregator);

            smartDoor.Open();
            Thread.Sleep(2200);
            smartDoor.Close();
        }
    }
}
