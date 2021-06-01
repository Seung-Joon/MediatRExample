using MediatR;

namespace MediatRExample
{
    public class NotificationMessage : INotification
    {
        public string NotifyText {get; set;}
    }
}