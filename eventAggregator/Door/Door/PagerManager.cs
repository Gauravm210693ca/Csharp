using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public class PagerManager 
    {
        private EventAggregator eventAggregator;

        public PagerManager(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<DoorState>(Update);
        }

        public void Update(DoorState state)
        {
            Console.WriteLine("Pager");
        }
    }
}
