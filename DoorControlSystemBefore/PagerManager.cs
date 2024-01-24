using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsControlSystem
{
    public class PagerManager:INotifier
    {
        private DoorState currentState;
        public void Update(DoorState state)
        {
            this.currentState = state;
            Console.WriteLine("Pager");
        }
    }
}
