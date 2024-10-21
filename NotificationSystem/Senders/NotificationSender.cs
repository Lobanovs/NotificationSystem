using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.Interfaces;

namespace NotificationSystem.Senders
{
    public abstract class NotificationSender
    {
        protected INotification notification;

        protected NotificationSender(INotification notification)
        {
            this.notification = notification;
        }

        public abstract void SendNotification(string message);
    }
}
