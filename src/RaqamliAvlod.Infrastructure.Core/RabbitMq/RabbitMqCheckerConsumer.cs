using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Serilog;
using System.Text;
#pragma warning disable
namespace RaqamliAvlod.Infrastructure.Core.RabbitMQ
{
    public class RabbitMqCheckerConsumer : BackgroundService
    {
        private readonly ConnectionFactory _factory;
        private readonly IConnection _conn;
        private readonly IModel _channel;
        private readonly string _queueName;
        private readonly IServiceProvider _serviceProvider;

        public RabbitMqCheckerConsumer(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
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
            _queueName = subconfiguration.GetSection("ConsumerRabbitQueue").Value;
            _conn = _factory.CreateConnection();
            _channel = _conn.CreateModel();
            _channel.QueueDeclare(queue: _queueName,
                                    durable: true,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);
            _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += Receive_Handle;
            _channel.BasicConsume(_queueName, false, consumer);
        }

        private void Receive_Handle(object sender, BasicDeliverEventArgs model)
        {
            try
            {
                var body = model.Body;
                string json = Encoding.UTF8.GetString(body.ToArray());
                Log.Error("Rabbit2->Received /n" + json);
                
            }
            catch (Exception error)
            {
                Log.Fatal("Error with Receiver\n" + error.Message);
            }
            finally
            {
                _channel.BasicAck(deliveryTag: model.DeliveryTag, multiple: false);
            }
        }
    }
}
