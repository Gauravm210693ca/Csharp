using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    public class EventAggregator
    {

        private Dictionary<Type, List<Action<object>>> subscribers = new Dictionary<Type, List<Action<object>>>();


        public void Subscribe<TEvent>(Action<TEvent> action)
        {
            Type eventType = typeof(TEvent);

            if (!subscribers.ContainsKey(eventType))
            {
                subscribers[eventType] = new List<Action<object>>();
            }

            subscribers[eventType].Add(e => action((TEvent)e));
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            Type eventType = typeof(TEvent);

            if (subscribers.ContainsKey(eventType))
            {
                foreach (var subscriber in subscribers[eventType])
                {
                    subscriber.Invoke(eventToPublish);
                }
            }
        }
    }
}
