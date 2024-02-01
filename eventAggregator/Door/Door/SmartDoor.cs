using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public class SmartDoor : SimpleDoor
    {
        private EventAggregator eventAggregator;
        public DoorState currentState;
        public DateTime openedTime;
        public SmartDoor(TimerManager timerManager, EventAggregator eventAggregator):base()
        {
            this.eventAggregator = eventAggregator;
            eventAggregator.Subscribe<DoorState>(StateChanged);
            timerManager.StartTimer(this);
        }

        public override void Open()
        {
            if (currentState == DoorState.CLOSED)
            {
                currentState = DoorState.OPENED;
                openedTime = DateTime.Now;
                eventAggregator.Publish(currentState);
            }
        }

        public override void Close()
        {
            if (currentState == DoorState.OPENED)
            {
                currentState = DoorState.CLOSED;
                eventAggregator.Publish(currentState);
            }
        }

        private void StateChanged(DoorState state)
        {
            Console.WriteLine($"SmartDoor State Changed: {state}");
        }
    }
}
