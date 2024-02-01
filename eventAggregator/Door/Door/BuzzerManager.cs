using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public class BuzzerManager 
    {
        private EventAggregator eventAggregator;

        public BuzzerManager(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<DoorState>(Update);
        }

        public void Update(DoorState state)
        {
            Console.WriteLine("Alert!!!");
        }
    }
}
