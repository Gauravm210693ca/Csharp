using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoorsControlSystem
{
    public class TimerManager
    {
        private DoorState currentState;
        private DateTime openedTime;
        private int ThresholdInSeconds = 2;
        SmartDoor smartDoor;
        private Timer timer;
        
        public TimerManager()
        {
              
        }
        public void StartTimer(SmartDoor smartDoor)
        {
            this.smartDoor = smartDoor;
            timer = new Timer(CheckAlertRequired, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }
        public void CheckAlertRequired(object obj)
        {
            
            if (smartDoor.currentState == DoorState.OPENED)
            {
                
                TimeSpan duration = DateTime.Now - smartDoor.openedTime;
                if (duration.TotalSeconds > ThresholdInSeconds)
                {
                    smartDoor.Notify(true);
                }
            }

        }
    }
}
