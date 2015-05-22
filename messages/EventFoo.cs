using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messages
{
    public class EventFoo : IEvent
    {
        public Guid Id { get; set; }

        public EventFoo()
        {
            Id = Guid.NewGuid();
        }
    }
}
