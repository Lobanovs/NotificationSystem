using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.Interfaces;
using NotificationSystem.Models;
using NotificationSystem.Senders;

class Program
{
    static void Main(string[] args)
    {
       
        INotification emailNotification = new EmailNotification("user@example.com");
        NotificationSender textEmailSender = new TextNotificationSender(emailNotification);
        textEmailSender.SendNotification("Это текстовое сообщение для Email.");

       
        INotification smsNotification = new SMSNotification("+123456789");
        NotificationSender htmlSmsSender = new HtmlNotificationSender(smsNotification);
        htmlSmsSender.SendNotification("Это сообщение для SMS в HTML-формате.");
    }
}

