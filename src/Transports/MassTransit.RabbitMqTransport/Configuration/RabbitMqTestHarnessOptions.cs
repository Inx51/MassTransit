#nullable enable
namespace MassTransit
{
    public class RabbitMqTestHarnessOptions
    {
        /// <summary>
        /// Attempts to create the virtual host on the RabbitMQ broker using the management API. The <see cref="RabbitMqTransportOptions" /> will be
        /// used to obtain the host, port, management port, etc.
        /// </summary>
        public bool CreateVirtualHostIfNotExists { get; set; }

        /// <summary>
        /// Remove all exchanges and queues from the virtual host when starting the test harness (via a hosted service)
        /// </summary>
        public bool CleanVirtualHost { get; set; }

        /// <summary>
        /// If the root virtual host is being used, ensure that the virtual host can be cleaned to avoid accidental destruction
        /// </summary>
        public bool ForceCleanRootVirtualHost { get; set; }
    }
}
