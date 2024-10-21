using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NotificationSystem.Interfaces;

namespace NotificationSystem.Senders
{
    public class TextNotificationSender : NotificationSender
    {
        public TextNotificationSender(INotification notification) : base(notification) { }

        public override void SendNotification(string message)
        {
            string formattedMessage = $"Текстовое уведомление: {message}";
            notification.Send(formattedMessage);
        }
    }
}

