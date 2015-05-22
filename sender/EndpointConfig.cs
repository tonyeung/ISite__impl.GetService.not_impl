
namespace sender
{
    using messages;
    using NServiceBus;
    using NServiceBus.Logging;
    using System;

    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            LogManager.Use<DefaultFactory>().Level(LogLevel.Info);
            configuration.UseSerialization<NServiceBus.JsonSerializer>();
            configuration.EnableInstallers();
            configuration.UsePersistence<InMemoryPersistence>();

            IStartableBus startableBus = Bus.Create(configuration);
            using (IBus bus = startableBus.Start())
            {
                Start(bus);
            }
        }

        static void Start(IBus bus)
        {
            Console.WriteLine("Press 'Enter' to publish a message.To exit, Ctrl + C");
            while (Console.ReadLine() != null)
            {
                var message = new EventFoo();
                bus.Publish(message);

                Console.WriteLine("Published event with Id {0}.", message.Id);
            }
        }
    }
}
