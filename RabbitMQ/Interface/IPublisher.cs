namespace RabbitMQPublisher.Interface
{
    public interface IPublisher
    {
        Task PublishMessageAsync(string message, string exchangeName, string routingKey, string queueName, string exchageType);
    }
}
