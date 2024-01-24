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
        TimerManager timerManagerObj;
        public SmartDoor(TimerManager timerManager)
        {
            openedTime = DateTime.Now;
            timerManagerObj = timerManager; 
        }
        public override void Open()
        {
            
            if (this.currentState == DoorState.CLOSED)
            {
                this.currentState = DoorState.OPENED;
                openedTime = DateTime.Now;
               
            }
            
        }

        public override void Close()
        {
            if (this.currentState == DoorState.OPENED)
            {
                this.currentState = DoorState.CLOSED;
            }
            
        }
       
        public void Notify(bool value)
        {
            if (value == true)
            {
                StateChanged.Invoke(this.currentState);
            }
        }

        
    }
}
