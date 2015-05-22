using messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISite__impl.GetService.not_impl
{
    public class EventFooPublishedHandler : IHandleMessages<EventFoo>
    {
        public void Handle(EventFoo message)
        {
            Console.WriteLine(message.Id.ToString());
        }
    }
}
