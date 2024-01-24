using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoorsControlSystem
{
    public class SmartDoor:SimpleDoor
    {
        
        public event Action<DoorState> StateChanged;
        public DateTime openedTime;
        public DoorState currentState;
        openedTime = DateTime.Now;
        public override void Open()
        {
            
            if (this.currentState == DoorState.CLOSED)
            {
                this.currentState = DoorState.OPENED;
                StateChanged.Invoke(this.currentState);
               
            }
            
        }

        public override void Close()
        {
            if (this.currentState == DoorState.OPENED)
            {
                this.currentState = DoorState.CLOSED;
                StateChanged.Invoke(this.currentState);
            }
            
        }
       
       

        
    }
}
