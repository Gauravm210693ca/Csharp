using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public enum DoorState
    {
        CLOSED,
        OPENED
    }

    public class SimpleDoor
    {
        protected DoorState state;
        private EventAggregator  eventAggregator;
        public virtual void Open()
        {
            state = DoorState.OPENED;
            eventAggregator.Publish(state); 
        }

        public virtual void Close()
        {
            state = DoorState.CLOSED;
            eventAggregator.Publish(state);
        }
    }
}
