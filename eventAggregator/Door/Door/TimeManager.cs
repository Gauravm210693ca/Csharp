using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Door
{
    public class TimerManager
    {
        private EventAggregator eventAggregator;
        private Timer timer;

        public TimerManager(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public void StartTimer(SmartDoor smartDoor)
        {
            timer = new Timer(CheckAlertRequired, smartDoor, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void CheckAlertRequired(object obj)
        {
            SmartDoor smartDoor = (SmartDoor)obj;

            if (smartDoor.currentState == DoorState.OPENED)
            {
                TimeSpan duration = DateTime.Now - smartDoor.openedTime;
                if (duration.TotalSeconds > 2)
                {
                    eventAggregator.Publish(smartDoor.currentState);
                }
            }
        }
    }
}
