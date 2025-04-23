#nullable disable
namespace NotificationService.Models
{
    public class EventMessage<T>
    {
        public string EventType { get; set; }
        public T Data { get; set; }
    }
}
