using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DoorsControlSystem
{
    public class BuzzerManager:INotifier
    {
        
        private DoorState currentState;
        public void Update(DoorState state)
        {
            this.currentState = state;
            Console.WriteLine("Alert!!!");
        }
        
    }
}
