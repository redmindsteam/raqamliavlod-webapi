using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RaqamliAvlod.Infrastructure.Core.Interfaces.Shared;

#pragma warning disable
namespace RaqamliAvlod.Infrastructure.Core.RabbitMQ
{
    public class RabbitMqCheckerProducer : ICheckerProducer
    {
        private readonly ConnectionFactory _factory;
        private readonly IConnection _conn;
        private readonly IModel _channel;
        private readonly string _queueName;

        public RabbitMqCheckerProducer(IConfiguration configuration)
        {
            var subconfiguration = configuration.GetSection("RabbitMq");
            var uri = subconfiguration.GetSection("Uri").Value;
            if (String.IsNullOrEmpty(uri) is false)
                _factory = new ConnectionFactory() { Uri = new Uri(uri) };
            else _factory = new ConnectionFactory()
            {
                HostName = subconfiguration.GetSection("Host").Value,
                Port = int.Parse(subconfiguration.GetSection("Port").Value),
                UserName = subconfiguration.GetSection("Username").Value,
                Password = subconfiguration.GetSection("Password").Value,
            };
            _queueName = subconfiguration.GetSection("ProducerRabbitQueue").Value;

            _conn = _factory.CreateConnection();
            _channel = _conn.CreateModel();
            _channel.QueueDeclare(queue: _queueName,
                                    durable: true,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);
            _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
        }
    }
}