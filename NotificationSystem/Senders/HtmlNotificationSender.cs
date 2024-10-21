using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.Interfaces;

namespace NotificationSystem.Senders
{
    public class HtmlNotificationSender : NotificationSender
    {
        public HtmlNotificationSender(INotification notification) : base(notification) { }

        public override void SendNotification(string message)
        {
            string formattedMessage = $"<html><body><p>HTML уведомление: {message}</p></body></html>";
            notification.Send(formattedMessage);
        }
    }
}
