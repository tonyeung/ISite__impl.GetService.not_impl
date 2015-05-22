
namespace ISite__impl.GetService.not_impl
{
    using NServiceBus;
    using NServiceBus.Logging;

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
        }
    }
}
