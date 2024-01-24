using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoorsControlSystem
{
    public enum DoorState
    {
        CLOSED,
        OPENED
    }
    
    public class SimpleDoor
    {
        protected DoorState state;
        
        public SimpleDoor()
        {
            state = DoorState.CLOSED;
        }
        public virtual void Open()
        {
            state = DoorState.OPENED;
        }
        public virtual void Close()
        {
            state = DoorState.CLOSED;
        }
    }
}
