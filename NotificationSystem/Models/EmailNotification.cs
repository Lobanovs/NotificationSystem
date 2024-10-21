using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationSystem.Interfaces;

namespace NotificationSystem.Models
{
    public class EmailNotification : INotification
    {
        private readonly string _emailAddress;

        public EmailNotification(string emailAddress)
        {
            _emailAddress = emailAddress;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Отправка Email на {_emailAddress}: {message}");
        }
    }
}
